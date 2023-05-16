using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Configuration;

namespace Editor_De_Imagens.Servicos
{
    public class GestorDeImagens
    {


        /// <summary>
        /// Gira e/ou inverte uma imagem
        /// </summary>
        /// <param name="original">Imagem original</param>
        /// <param name="rotateFlipType">Tipo de processamento</param>
        /// <returns>Imagem tratada</returns>
        public static Bitmap GirarOuInverter(Image original, RotateFlipType rotateFlipType)
        {
            Bitmap temp = (Bitmap)original;
            Bitmap bmap = (Bitmap)temp.Clone();
            bmap.RotateFlip(rotateFlipType);
            return (Bitmap)bmap.Clone();
        }

        /// <summary>
        /// Redimenciona uma imagem
        /// </summary>
        /// <param name="original">Imagem original</param>
        /// <param name="largura">Largura</param>
        /// <param name="altura">Altura</param>
        /// <returns>Imagem tratada</returns>
        public static Bitmap Redimencionar(Image original, int largura, int altura)
        {
            if (largura != 0 && altura != 0)
            {
                Bitmap temp = (Bitmap)original;
                Bitmap bmap = new Bitmap(largura, altura, temp.PixelFormat);

                double nWidthFactor = (double)temp.Width / (double)largura;
                double nHeightFactor = (double)temp.Height / (double)altura;

                double fx, fy, nx, ny;
                int cx, cy, fr_x, fr_y;
                Color color1 = new Color();
                Color color2 = new Color();
                Color color3 = new Color();
                Color color4 = new Color();
                byte nRed, nGreen, nBlue;

                byte bp1, bp2;

                for (int x = 0; x < bmap.Width; ++x)
                {
                    for (int y = 0; y < bmap.Height; ++y)
                    {

                        fr_x = (int)Math.Floor(x * nWidthFactor);
                        fr_y = (int)Math.Floor(y * nHeightFactor);
                        cx = fr_x + 1;
                        if (cx >= temp.Width) cx = fr_x;
                        cy = fr_y + 1;
                        if (cy >= temp.Height) cy = fr_y;
                        fx = x * nWidthFactor - fr_x;
                        fy = y * nHeightFactor - fr_y;
                        nx = 1.0 - fx;
                        ny = 1.0 - fy;

                        color1 = temp.GetPixel(fr_x, fr_y);
                        color2 = temp.GetPixel(cx, fr_y);
                        color3 = temp.GetPixel(fr_x, cy);
                        color4 = temp.GetPixel(cx, cy);

                        // Blue
                        bp1 = (byte)(nx * color1.B + fx * color2.B);

                        bp2 = (byte)(nx * color3.B + fx * color4.B);

                        nBlue = (byte)(ny * (double)(bp1) + fy * (double)(bp2));

                        // Green
                        bp1 = (byte)(nx * color1.G + fx * color2.G);

                        bp2 = (byte)(nx * color3.G + fx * color4.G);

                        nGreen = (byte)(ny * (double)(bp1) + fy * (double)(bp2));

                        // Red
                        bp1 = (byte)(nx * color1.R + fx * color2.R);

                        bp2 = (byte)(nx * color3.R + fx * color4.R);

                        nRed = (byte)(ny * (double)(bp1) + fy * (double)(bp2));

                        bmap.SetPixel(x, y, Color.FromArgb(255, nRed, nGreen, nBlue));
                    }
                }

                return (Bitmap)bmap.Clone();
            }
            throw new Exception("Valores de largura e/ou altura de imagem menores ou igual a 0. A imagem não pode ser redimencionada!");
        }

        /// <summary>
        /// Define o constraste de uma imagem
        /// </summary>
        /// <param name="original">Imagem original</param>
        /// <param name="contrast">Taxa de contraste</param>
        /// <returns>Imagem tratada</returns>
        public static Bitmap DefinirContraste(Image original, double contrast)
        {
            Bitmap temp = (Bitmap)original;
            Bitmap bmap = (Bitmap)temp.Clone();
            if (contrast < -100) contrast = -100;
            if (contrast > 100) contrast = 100;
            contrast = (100.0 + contrast) / 100.0;
            contrast *= contrast;
            Color c;
            for (int i = 0; i < bmap.Width; i++)
            {
                for (int j = 0; j < bmap.Height; j++)
                {
                    c = bmap.GetPixel(i, j);
                    double pR = c.R / 255.0;
                    pR -= 0.5;
                    pR *= contrast;
                    pR += 0.5;
                    pR *= 255;
                    if (pR < 0) pR = 0;
                    if (pR > 255) pR = 255;

                    double pG = c.G / 255.0;
                    pG -= 0.5;
                    pG *= contrast;
                    pG += 0.5;
                    pG *= 255;
                    if (pG < 0) pG = 0;
                    if (pG > 255) pG = 255;

                    double pB = c.B / 255.0;
                    pB -= 0.5;
                    pB *= contrast;
                    pB += 0.5;
                    pB *= 255;
                    if (pB < 0) pB = 0;
                    if (pB > 255) pB = 255;

                    bmap.SetPixel(i, j, Color.FromArgb((byte)pR, (byte)pG, (byte)pB));
                }
            }

            return (Bitmap)bmap.Clone();
        }

        /// <summary>
        /// Aplica taxa de brilho numa imagem
        /// </summary>
        /// <param name="original">Imagem original</param>
        /// <param name="brightness">Valor do brilho</param>
        /// <returns>Imagem tratada</returns>
        public static Image DefinirBrilho(Image original, int brightness)
        {
            Bitmap temp = (Bitmap)original;
            Bitmap bmap = (Bitmap)temp.Clone();
            if (brightness < -255) brightness = -255;
            if (brightness > 255) brightness = 255;
            Color c;
            for (int i = 0; i < bmap.Width; i++)
            {
                for (int j = 0; j < bmap.Height; j++)
                {
                    c = bmap.GetPixel(i, j);
                    int cR = c.R + brightness;
                    int cG = c.G + brightness;
                    int cB = c.B + brightness;

                    if (cR < 0) cR = 1;
                    if (cR > 255) cR = 255;

                    if (cG < 0) cG = 1;
                    if (cG > 255) cG = 255;

                    if (cB < 0) cB = 1;
                    if (cB > 255) cB = 255;

                    bmap.SetPixel(i, j, Color.FromArgb((byte)cR, (byte)cG, (byte)cB));
                }
            }

            return (Bitmap)bmap.Clone();
        }

        public static Bitmap Pixelizar(Image original, int fator)
        {
            Bitmap aux = (Bitmap)original.Clone();
            var temp = new Bitmap(aux, aux.Width * fator, aux.Height * fator);
            Graphics g = Graphics.FromImage(temp);
            g.Clear(Color.Transparent);

            for (int i = 0; i < original.Width; i++)
            {
                for (int j = 0; j < original.Height; j++)
                {
                    var color = aux.GetPixel(i, j);
                    var b = new SolidBrush(color);
                    var r = new Rectangle(i*fator, j*fator, fator, fator);
                    g.FillRectangle(b, r);
                }
            }

            return temp;
        }

        /// <summary>
        /// Aplica Efeito Gamma
        /// </summary>
        /// <param name="original">Imagem original</param>
        /// <param name="red">Vermelho</param>
        /// <param name="green">Verde</param>
        /// <param name="blue">Azul</param>
        /// <returns>Imagem tratada</returns>
        public static Bitmap DefinirGamma(Image original, double red, double green, double blue)
        {
            Bitmap temp = (Bitmap)original;
            Bitmap bmap = (Bitmap)temp.Clone();
            Color c;
            byte[] redGamma = CreateGammaArray(red);
            byte[] greenGamma = CreateGammaArray(green);
            byte[] blueGamma = CreateGammaArray(blue);
            for (int i = 0; i < bmap.Width; i++)
            {
                for (int j = 0; j < bmap.Height; j++)
                {
                    c = bmap.GetPixel(i, j);
                    bmap.SetPixel(i, j, Color.FromArgb(redGamma[c.R],
                       greenGamma[c.G], blueGamma[c.B]));
                }
            }

            return (Bitmap)bmap.Clone();
        }

        private static byte[] CreateGammaArray(double color)
        {
            byte[] gammaArray = new byte[256];
            for (int i = 0; i < 256; ++i)
            {
                gammaArray[i] = (byte)Math.Min(255,
        (int)((255.0 * Math.Pow(i / 255.0, 1.0 / color)) + 0.5));
            }
            return gammaArray;
        }

        /// <summary>
        /// Aplica uma camada de cor sobre uma imagem
        /// </summary>
        /// <param name="original">Imagem original</param>
        /// <param name="colorFilterType">Cor</param>
        /// <returns>Imagem Tratada</returns>
        public static Bitmap EfeitoFiltroCorPrimaria(Image original, ColorFilterTypes colorFilterType)
        {
            Bitmap temp = (Bitmap)original;
            Bitmap bmap = (Bitmap)temp.Clone();
            Color c;
            for (int i = 0; i < bmap.Width; i++)
            {
                for (int j = 0; j < bmap.Height; j++)
                {
                    c = bmap.GetPixel(i, j);
                    int nPixelR = 0;
                    int nPixelG = 0;
                    int nPixelB = 0;
                    if (colorFilterType == ColorFilterTypes.Red)
                    {
                        nPixelR = c.R;
                        nPixelG = c.G - 255;
                        nPixelB = c.B - 255;
                    }
                    else if (colorFilterType == ColorFilterTypes.Green)
                    {
                        nPixelR = c.R - 255;
                        nPixelG = c.G;
                        nPixelB = c.B - 255;
                    }
                    else if (colorFilterType == ColorFilterTypes.Blue)
                    {
                        nPixelR = c.R - 255;
                        nPixelG = c.G - 255;
                        nPixelB = c.B;
                    }
                    nPixelR = Math.Max(nPixelR, 0);
                    nPixelR = Math.Min(255, nPixelR);

                    nPixelG = Math.Max(nPixelG, 0);
                    nPixelG = Math.Min(255, nPixelG);

                    nPixelB = Math.Max(nPixelB, 0);
                    nPixelB = Math.Min(255, nPixelB);

                    bmap.SetPixel(i, j, Color.FromArgb((byte)nPixelR,
                      (byte)nPixelG, (byte)nPixelB));
                }
            }
            return (Bitmap)bmap.Clone();
        }


        /// <summary>
        /// Inverte as cores de uma imagme
        /// </summary>
        /// <param name="original"></param>
        /// <returns>Imagem tratada</returns>
        public static Bitmap EfeitoNegativo(Image original)
        {
            Bitmap temp = (Bitmap)original;
            Bitmap bmap = (Bitmap)temp.Clone();
            Color c;
            for (int i = 0; i < bmap.Width; i++)
            {
                for (int j = 0; j < bmap.Height; j++)
                {
                    c = bmap.GetPixel(i, j);
                    bmap.SetPixel(i, j, Color.FromArgb(c.A, 255 - c.R, 255 - c.G, 255 - c.B));
                }
            }
            return (Bitmap)bmap.Clone();
        }

        /// <summary>
        /// Converte uma imagem colorida para preto e branco
        /// </summary>
        /// <param name="original">Imagem original</param>
        /// <returns>Imagem em escala de cinza</returns>
        public static Bitmap EfeitoEscalaEmCinza(Image original)
        {
            Bitmap newBitmap = new Bitmap(original.Width, original.Height);

            Graphics g = Graphics.FromImage(newBitmap);

            ColorMatrix colorMatrix = new ColorMatrix(
               new float[][]
                {
                   new float[] {.3f, .3f, .3f, 0, 0},
                   new float[] {.59f, .59f, .59f, 0, 0},
                   new float[] {.11f, .11f, .11f, 0, 0},
                   new float[] {0, 0, 0, 1, 0},
                   new float[] {0, 0, 0, 0, 1}
                });

            ImageAttributes attributes = new ImageAttributes();

            attributes.SetColorMatrix(colorMatrix);

            g.DrawImage(original, new Rectangle(0, 0, original.Width, original.Height),
                0, 0, original.Width, original.Height, GraphicsUnit.Pixel, attributes);

            g.Dispose();
            return newBitmap;
        }

        /// <summary>
        /// Aplica uma matriz de cores
        /// </summary>
        /// <param name="original">Imagem original</param>
        /// <param name="colorMatrix">Matriz de cores</param>
        /// <returns>Imagem Tratada</returns>
        public static Bitmap AplicarMatrix(Image original, ColorMatrix colorMatrix)
        {
            Bitmap newBitmap = new Bitmap(original.Width, original.Height);

            Graphics g = Graphics.FromImage(newBitmap);

            ImageAttributes attributes = new ImageAttributes();

            attributes.SetColorMatrix(colorMatrix);

            g.DrawImage(original, new Rectangle(0, 0, original.Width, original.Height),
                0, 0, original.Width, original.Height, GraphicsUnit.Pixel, attributes);

            g.Dispose();
            return newBitmap;
        }

        /// <summary>
        /// Desfoca uma imagem
        /// </summary>
        /// <param name="image">Imagem original</param>
        /// <param name="blurSize">Raio de pixels do desfoque</param>
        /// <returns>Imagem desfocada</returns>
        public static Bitmap EfeitoBlur(Image image, Int32 blurSize)
        {
            var rectangle = new Rectangle(0, 0, image.Width, image.Height);
            Bitmap blurred = new Bitmap(image.Width, image.Height);

            using (Graphics graphics = Graphics.FromImage(blurred))
                graphics.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height),
                    new Rectangle(0, 0, image.Width, image.Height), GraphicsUnit.Pixel);

            for (Int32 xx = rectangle.X; xx < rectangle.X + rectangle.Width; xx++)
            {
                for (Int32 yy = rectangle.Y; yy < rectangle.Y + rectangle.Height; yy++)
                {
                    Int32 avgR = 0, avgG = 0, avgB = 0;
                    Int32 blurPixelCount = 0;

                    for (Int32 x = xx; (x < xx + blurSize && x < image.Width); x++)
                    {
                        for (Int32 y = yy; (y < yy + blurSize && y < image.Height); y++)
                        {
                            Color pixel = blurred.GetPixel(x, y);

                            avgR += pixel.R;
                            avgG += pixel.G;
                            avgB += pixel.B;

                            blurPixelCount++;
                        }
                    }

                    avgR = avgR / blurPixelCount;
                    avgG = avgG / blurPixelCount;
                    avgB = avgB / blurPixelCount;

                    for (Int32 x = xx; x < xx + blurSize && x < image.Width && x < rectangle.Width; x++)
                        for (Int32 y = yy; y < yy + blurSize && y < image.Height && y < rectangle.Height; y++)
                            blurred.SetPixel(x, y, Color.FromArgb(avgR, avgG, avgB));
                }
            }

            return blurred;
        }

        /// <summary>
        /// Corta uma imagem a partir de um ponto retangularmente
        /// </summary>
        /// <param name="original">Imagem original</param>
        /// <param name="xPosition">Coordenada X do inicio do corte</param>
        /// <param name="yPosition">Coordenada Y do inicio do corte</param>
        /// <param name="width">Largura</param>
        /// <param name="height">Altura</param>
        /// <returns>Imagem tratada</returns>
        public static Bitmap Cortar(Image original, int xPosition, int yPosition, int width, int height)
        {
            Bitmap temp = (Bitmap)original;
            Bitmap bmap = (Bitmap)temp.Clone();
            if (xPosition + width > original.Width)
                width = original.Width - xPosition;
            if (yPosition + height > original.Height)
                height = original.Height - yPosition;
            Rectangle rect = new Rectangle(xPosition, yPosition, width, height);
            return (Bitmap)bmap.Clone(rect, bmap.PixelFormat);
        }

        /// <summary>
        /// Desenha a area de corte para ser utilizada para previzualizar o corte de uma imagem
        /// </summary>
        /// <param name="original">Imagem Original</param>
        /// <param name="xPosition">Coordenada X do inicio do corte</param>
        /// <param name="yPosition">Coordenada Y do inicio do corte</param>
        /// <param name="width">Largura</param>
        /// <param name="height">Altura</param>
        /// <returns>Imagem tratada</returns>
        public static Bitmap DesenharPrevisualizacaoDeCorte(Image original, int xPosition, int yPosition, int width, int height)
        {
            var corte = (Bitmap)original;
            Bitmap bmap = (Bitmap)corte.Clone();
            Graphics gr = Graphics.FromImage(bmap);
            Brush cBrush = new Pen(Color.FromArgb(150, Color.White)).Brush;
            Rectangle rect1 = new Rectangle(0, 0, original.Width, yPosition);
            Rectangle rect2 = new Rectangle(0, yPosition, xPosition, height);
            Rectangle rect3 = new Rectangle(0, (yPosition + height), original.Width, original.Height);
            Rectangle rect4 = new Rectangle((xPosition + width), yPosition, (original.Width - xPosition - width), height);
            gr.FillRectangle(cBrush, rect1);
            gr.FillRectangle(cBrush, rect2);
            gr.FillRectangle(cBrush, rect3);
            gr.FillRectangle(cBrush, rect4);
            return (Bitmap)bmap.Clone();
        }

        /// <summary>
        /// Desenha a area de corte de uma fragmanetação
        /// </summary>
        /// <param name="original">Imagem original</param>
        /// <param name="tamanho">Tamanho dos fragmentos</param>
        /// <param name="qtdimgs">Número de imagens que serão salvas.</param>
        /// <returns></returns>
        public static Bitmap DesenharPrevisualizacaoFragmentacao(Image original, Size tamanho, ref int qtdimgs)
        {
            var corte = (Bitmap)original;
            Bitmap bmap = (Bitmap)corte.Clone();
            Graphics gr = Graphics.FromImage(bmap);
            var cPen = new Pen(Color.FromArgb(150, Color.Red));
            cPen.Width = 1;

            var retangulos = ObterRetangulosFragmentos(bmap.Size, tamanho);

            foreach (var retangulo in retangulos)
            {
                gr.DrawRectangle(cPen, retangulo);
            }

            qtdimgs = retangulos.Count;
            return (Bitmap)bmap.Clone();
        }

        /// <summary>
        /// Desenha um texto numa imagem
        /// </summary>
        /// <param name="original">Imagem original</param>
        /// <param name="text">Texto</param>
        /// <param name="xPosition">Posição eixo X</param>
        /// <param name="yPosition">Posição eixo Y</param>
        /// <param name="fontName">Fonte</param>
        /// <param name="fontSize">Tamanho da fonte</param>
        /// <param name="fontStyle">Estilo da fonte</param>
        /// <param name="colorName1">Cor 1</param>
        /// <param name="colorName2">Cor 2</param>
        /// <returns>Imagem tratada</returns>
        public static Bitmap InserirTexto(Image original, string text, int xPosition, int yPosition, string fontName, float fontSize, string fontStyle, string colorName1, string colorName2)
        {
            Bitmap temp = (Bitmap)original;
            Bitmap bmap = (Bitmap)temp.Clone();
            Graphics gr = Graphics.FromImage(bmap);
            if (string.IsNullOrEmpty(fontName))
                fontName = "Times New Roman";
            if (fontSize.Equals(null))
                fontSize = 10.0F;
            Font font = new Font(fontName, fontSize);
            if (!string.IsNullOrEmpty(fontStyle))
            {
                FontStyle fStyle = FontStyle.Regular;
                switch (fontStyle.ToLower())
                {
                    case "bold":
                        fStyle = FontStyle.Bold;
                        break;
                    case "italic":
                        fStyle = FontStyle.Italic;
                        break;
                    case "underline":
                        fStyle = FontStyle.Underline;
                        break;
                    case "strikeout":
                        fStyle = FontStyle.Strikeout;
                        break;

                }
                font = new Font(fontName, fontSize, fStyle);
            }
            if (string.IsNullOrEmpty(colorName1))
                colorName1 = "Black";
            if (string.IsNullOrEmpty(colorName2))
                colorName2 = colorName1;
            Color color1 = Color.FromName(colorName1);
            Color color2 = Color.FromName(colorName2);
            int gW = (int)(text.Length * fontSize);
            gW = gW == 0 ? 10 : gW;
            LinearGradientBrush LGBrush = new LinearGradientBrush(new Rectangle(0, 0, gW, (int)fontSize), color1, color2, LinearGradientMode.Vertical);
            gr.DrawString(text, font, LGBrush, xPosition, yPosition);

            return (Bitmap)bmap.Clone();
        }

        /// <summary>
        /// Insere uma imagem sobre outra
        /// </summary>
        /// <param name="fundo">Imagem do plano de fundo</param>
        /// <param name="sobreposicao">Imagem a ser inserida</param>
        /// <param name="xPosition">Posição X</param>
        /// <param name="yPosition">Posição Y</param>
        /// <returns>Imagem resultante</returns>
        public static Bitmap InserirImage(Image fundo, Image sobreposicao, int xPosition, int yPosition)
        {
            Bitmap temp = (Bitmap)fundo;
            Bitmap bmap = (Bitmap)temp.Clone();
            Graphics gr = Graphics.FromImage(bmap);

            Rectangle rect = new Rectangle(xPosition, yPosition, sobreposicao.Width, sobreposicao.Height);
            gr.DrawImage(sobreposicao, rect);

            return (Bitmap)bmap.Clone();
        }

        /// <summary>
        /// Insere uma figura geométrica na imagem
        /// </summary>
        /// <param name="original">Imagem original</param>
        /// <param name="shapeType"></param>
        /// <param name="xPosition"></param>
        /// <param name="yPosition"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="colorName"></param>
        /// <returns></returns>
        public static Bitmap InserirFormaGeometrica(Image original, FormaGeometrica shapeType, int xPosition, int yPosition, int width, int height, string colorName)
        {
            Bitmap temp = (Bitmap)original;
            Bitmap bmap = (Bitmap)temp.Clone();
            Graphics gr = Graphics.FromImage(bmap);
            if (string.IsNullOrEmpty(colorName))
                colorName = "Black";
            Pen pen = new Pen(Color.FromName(colorName));
            switch (shapeType)
            {
                case FormaGeometrica.CirculoPreenchido:
                    gr.FillEllipse(pen.Brush, xPosition,
                yPosition, width, height);
                    break;
                case FormaGeometrica.RetanguloPreenchido:
                    gr.FillRectangle(pen.Brush, xPosition,
                yPosition, width, height);
                    break;
                case FormaGeometrica.Circulo:
                    gr.DrawEllipse(pen, xPosition, yPosition, width, height);
                    break;
                case FormaGeometrica.Retangulo:
                    gr.DrawRectangle(pen, xPosition, yPosition, width, height);
                    break;

            }
            return (Bitmap)bmap.Clone();
        }

        /// <summary>
        /// Fragmenta uma imagem em imagens menores
        /// </summary>
        /// <param name="original">Imagem original</param>
        /// <param name="tamanhoFragmento">Tamanho do Fragmento</param>
        /// <returns></returns>
        public static IEnumerable<Bitmap> Fragmentar(Image original, Size tamanhoFragmento)
        {
            var pedacos = ObterRetangulosFragmentos(original.Size, tamanhoFragmento);

            foreach (var p in pedacos)
            {
                yield return Cortar((Bitmap)original.Clone(), p.X, p.Y, p.Width, p.Height);
            }
        }

        /// <summary>
        /// Troca uma cor por outra
        /// </summary>
        /// <param name="original">Imagem original</param>
        /// <param name="oldColor">Cor que será removida</param>
        /// <param name="newColor">Cor que substituirá a cor removida</param>
        /// <returns></returns>
        public static Bitmap ColorSwap(Image original, Color oldColor, Color newColor)
        {
            Graphics g = Graphics.FromImage(original);
            using (Bitmap bmp = (Bitmap)original.Clone())
            {
                // Set the image attribute's color mappings
                ColorMap[] colorMap = new ColorMap[1];
                colorMap[0] = new ColorMap();
                colorMap[0].OldColor = oldColor;
                colorMap[0].NewColor = newColor;
                ImageAttributes attr = new ImageAttributes();
                attr.SetRemapTable(colorMap);
                // Draw using the color map
                Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
                g.DrawImage(bmp, rect, 0, 0, rect.Width, rect.Height, GraphicsUnit.Pixel, attr);

                return bmp;
            }
        }

        /// <summary>
        /// Gira uma imagem numa angulação específica
        /// </summary>
        /// <param name="original">Imagem original</param>
        /// <param name="angle">Angulação a ser girada</param>
        /// <param name="bkColor">Cor de fundo</param>
        /// <returns></returns>
        public static Bitmap RotateImg(Image original, float angle, Color bkColor)
        {
            var bmp = (Bitmap)original.Clone();

            angle = angle % 360;
            if (angle > 180)
                angle -= 360;

            System.Drawing.Imaging.PixelFormat pf = default(System.Drawing.Imaging.PixelFormat);
            if (bkColor == Color.Transparent)
            {
                pf = System.Drawing.Imaging.PixelFormat.Format32bppArgb;
            }
            else
            {
                pf = bmp.PixelFormat;
            }

            float sin = (float)Math.Abs(Math.Sin(angle * Math.PI / 180.0)); // this function takes radians
            float cos = (float)Math.Abs(Math.Cos(angle * Math.PI / 180.0)); // this one too
            float newImgWidth = sin * bmp.Height + cos * bmp.Width;
            float newImgHeight = sin * bmp.Width + cos * bmp.Height;
            float originX = 0f;
            float originY = 0f;

            if (angle > 0)
            {
                if (angle <= 90)
                    originX = sin * bmp.Height;
                else
                {
                    originX = newImgWidth;
                    originY = newImgHeight - sin * bmp.Width;
                }
            }
            else
            {
                if (angle >= -90)
                    originY = sin * bmp.Width;
                else
                {
                    originX = newImgWidth - sin * bmp.Height;
                    originY = newImgHeight;
                }
            }

            Bitmap newImg = new Bitmap((int)newImgWidth, (int)newImgHeight, pf);
            Graphics g = Graphics.FromImage(newImg);
            g.Clear(bkColor);
            g.TranslateTransform(originX, originY); // offset the origin to our calculated values
            g.RotateTransform(angle); // set up rotate
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            g.DrawImageUnscaled(bmp, 0, 0); // draw the image at 0, 0
            g.Dispose();

            return newImg;
        }

        private static List<Rectangle> ObterRetangulosFragmentos(Size original, Size tamanhofragmento)
        {
            var retorno = new List<Rectangle>();
            int y = 0;

            do
            {
                int x = 0;

                do
                {
                    retorno.Add(new Rectangle(x, y, tamanhofragmento.Width, tamanhofragmento.Height));

                    x += tamanhofragmento.Width;
                } while (x < (original.Width + tamanhofragmento.Width));

                y += tamanhofragmento.Height;
            } while (y < (original.Height + tamanhofragmento.Height));

            var ret = new Rectangle(Point.Empty, original);

            retorno.RemoveAll(r => r.Width == 0 || r.Height == 0);
            retorno.RemoveAll(r => Rectangle.Intersect(ret, r).Width <= 0 || Rectangle.Intersect(ret, r).Height <= 0);

            return retorno;
        }

        public static Bitmap[] DecomporGif(Image Animation)
        {
            // Get the number of animation frames to copy into a Bitmap array

            int Length = Animation.GetFrameCount(FrameDimension.Time);

            // Allocate a Bitmap array to hold individual frames from the animation

            Bitmap[] Frames = new Bitmap[Length];

            // Copy the animation Bitmap frames into the Bitmap array

            for (int Index = 0; Index < Length; Index++)
            {
                // Set the current frame within the animation to be copied into the Bitmap array element

                Animation.SelectActiveFrame(FrameDimension.Time, Index);

                // Create a new Bitmap element within the Bitmap array in which to copy the next frame

                Frames[Index] = new Bitmap(Animation.Size.Width, Animation.Size.Height);

                // Copy the current animation frame into the new Bitmap array element

                Graphics.FromImage(Frames[Index]).DrawImage(Animation, new Point(0, 0));
            }

            // Return the array of Bitmap frames

            return Frames;
        }

        public static Bitmap UnificarGifDecomposto(Bitmap[] frames)
        {
            var raiz = Math.Sqrt(frames.Length);
            var dim = Math.Truncate(raiz);
            var raizexata = raiz - dim > 0;
            int q = (int)(raizexata ? dim : dim + 1);

            var img = new Bitmap(Properties.Resources.Transparente, frames[0].Width*q, frames[0].Height*q);

            var contador = 0;

            for (int i = 0; i < q; i++)
            {
                for (int j = 0; j < q; j++)
                {
                    img = InserirImage(img, frames[contador++], j*frames[0].Width, i*frames[0].Height);
                    if (contador == frames.Length)
                        break;
                }
                if (contador == frames.Length)
                    break;
            }

            return img;
        }
    }

    public enum FormaGeometrica
    {
        Circulo,
        Retangulo,
        CirculoPreenchido,
        RetanguloPreenchido
    }

    public enum ColorFilterTypes
    {
        Red,
        Green,
        Blue
    }
}
