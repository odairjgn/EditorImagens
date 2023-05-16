using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
using Editor_De_Imagens.Servicos;
using PlugInApi;

namespace Editor_De_Imagens.Classes
{
    public delegate void PrevisualizarMetodo(Image imagem);

    public class Trabalho
    {
        private readonly FileInfo _arquivoImagem;
        public Image ImagemDeTrabalho { get; private set; }
        public Image ImagemPrevisualizacao { get; private set; }
        public Historico Historico { get; private set; }

        private readonly PrevisualizarMetodo _previsualiza;

        public Trabalho(FileInfo arquivoImagem, PrevisualizarMetodo previsualiza)
        {
            _arquivoImagem = arquivoImagem;
            _previsualiza = previsualiza;
            Historico = new Historico();
            ImagemDeTrabalho = Image.FromFile(arquivoImagem.FullName);
            ImagemPrevisualizacao = (Image)ImagemDeTrabalho.Clone();
            Commit();
        }

        public Trabalho(Image arquivoImagem)
        {
            _previsualiza = imagem => { };
            Historico = new Historico();
            ImagemDeTrabalho = arquivoImagem;
            ImagemPrevisualizacao = (Image)ImagemDeTrabalho.Clone();
            Commit();
        }

        private void IniciaProcesso()
        {
            ImagemPrevisualizacao = (Image)ImagemDeTrabalho.Clone();
        }

        public void Discard()
        {
            ImagemPrevisualizacao = (Image)ImagemDeTrabalho.Clone();
            _previsualiza(ImagemDeTrabalho);
        }

        public void Commit(bool geraHistorio = true)
        {
            ImagemDeTrabalho = (Image)ImagemPrevisualizacao.Clone();
            _previsualiza(ImagemDeTrabalho);
            if (geraHistorio) Historico.AddPasso(new ItemHistorico((Image)ImagemDeTrabalho.Clone()));
        }

        public void Desfazer()
        {
            if (!Historico.HaComoDesfazer) return;

            Discard();
            ImagemPrevisualizacao = (Image)Historico.Desfazer().Imagem.Clone();
            Commit(false);
        }

        public void Refazer()
        {
            if (!Historico.HaComoRefazer) return;

            Discard();
            ImagemPrevisualizacao = (Image)Historico.Refazer().Imagem.Clone();
            Commit(false);
        }

        public void Salvar(FileInfo arquivo)
        {
            ImageFormat formato;

            switch (arquivo.Extension.ToUpper())
            {
                case ".JPG":
                    formato = ImageFormat.Jpeg;
                    break;
                case ".GIF":
                    formato = ImageFormat.Gif;
                    break;
                case ".PNG":
                    formato = ImageFormat.Png;
                    break;
                case ".BMP":
                    formato = ImageFormat.Bmp;
                    break;
                default:
                    throw new Exception("Formato de salvamento inválido!");
            }

            if (arquivo.Exists) arquivo.Delete();

            ImagemDeTrabalho.Save(arquivo.FullName, formato);
        }

        public void Imprimir(PrinterSettings impressora)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrinterSettings = impressora;
            //pd.DefaultPageSettings.PrinterSettings.PrinterName = nomeImpressora;
            pd.DefaultPageSettings.Landscape = ImagemPrevisualizacao.Width > ImagemPrevisualizacao.Height;
            pd.PrintPage += (sender, args) =>
            {
                Image i = ImagemPrevisualizacao;
                Rectangle m = args.MarginBounds;

                if ((double)i.Width / (double)i.Height > (double)m.Width / (double)m.Height) // image is wider
                {
                    m.Height = (int)((double)i.Height / (double)i.Width * (double)m.Width);
                }
                else
                {
                    m.Width = (int)((double)i.Width / (double)i.Height * (double)m.Height);
                }
                args.Graphics.DrawImage(i, m);
            };

            pd.Print();
        }

        public void CopiarParaClipBoard()
        {
            Clipboard.SetImage(ImagemPrevisualizacao);
        }

        public void Pixalizar(int fator)
        {
            IniciaProcesso();
            ImagemPrevisualizacao = GestorDeImagens.Pixelizar(ImagemPrevisualizacao, fator);
            _previsualiza(ImagemPrevisualizacao);
        }

        public void AplicaNegativo()
        {
            IniciaProcesso();
            ImagemPrevisualizacao = GestorDeImagens.EfeitoNegativo(ImagemPrevisualizacao);
            _previsualiza(ImagemPrevisualizacao);
        }

        public void GirarInverter(RotateFlipType acao)
        {
            IniciaProcesso();
            ImagemPrevisualizacao = GestorDeImagens.GirarOuInverter(ImagemPrevisualizacao, acao);
            _previsualiza(ImagemPrevisualizacao);
        }

        public void Redimencionar(int altura, int largura)
        {
            IniciaProcesso();
            ImagemPrevisualizacao = GestorDeImagens.Redimencionar(ImagemPrevisualizacao, altura, largura);
        }

        public void Contraste(double contraste)
        {
            IniciaProcesso();
            ImagemPrevisualizacao = GestorDeImagens.DefinirContraste(ImagemPrevisualizacao, contraste);
        }

        public void Brilho(int brilho)
        {
            IniciaProcesso();
            ImagemPrevisualizacao = GestorDeImagens.DefinirBrilho(ImagemPrevisualizacao, brilho);
        }

        public void Gamma(double r, double g, double b)
        {
            IniciaProcesso();
            ImagemPrevisualizacao = GestorDeImagens.DefinirGamma(ImagemPrevisualizacao, r, g, b);
        }

        public void FiltroCor(ColorFilterTypes cor)
        {
            IniciaProcesso();
            ImagemPrevisualizacao = GestorDeImagens.EfeitoFiltroCorPrimaria(ImagemPrevisualizacao, cor);
        }

        public void EscalaDeCinza()
        {
            IniciaProcesso();
            ImagemPrevisualizacao = GestorDeImagens.EfeitoEscalaEmCinza(ImagemPrevisualizacao);
        }

        public void Desfoque(int pixels)
        {
            IniciaProcesso();
            ImagemPrevisualizacao = GestorDeImagens.EfeitoBlur(ImagemPrevisualizacao, pixels);
        }

        public void Recortar(int xPosition, int yPosition, int width, int height)
        {
            IniciaProcesso();
            ImagemPrevisualizacao = GestorDeImagens.Cortar(ImagemPrevisualizacao, xPosition, yPosition, width, height);
        }

        public void InserirImagem(Image img, int x, int y)
        {
            IniciaProcesso();
            ImagemPrevisualizacao = GestorDeImagens.InserirImage(ImagemPrevisualizacao, img, x, y);
        }

        public void InserirForma(FormaGeometrica forma, int xPosition, int yPosition, int width, int height, string cor)
        {
            IniciaProcesso();
            ImagemPrevisualizacao = GestorDeImagens.InserirFormaGeometrica(ImagemPrevisualizacao, forma, xPosition, yPosition, width, height, cor);
        }

        public void InserirTexto(string texto, int xPosition, int yPosition, string fontName, float fontSize, string fontStyle, string cor1, string cor2)
        {
            IniciaProcesso();
            ImagemPrevisualizacao = GestorDeImagens.InserirTexto(ImagemPrevisualizacao, texto, xPosition, yPosition, fontName, fontSize, fontStyle, cor1, cor2);
        }

        public void AplicarMatrix(ColorMatrix matriz)
        {
            IniciaProcesso();
            ImagemPrevisualizacao = GestorDeImagens.AplicarMatrix(ImagemPrevisualizacao, matriz);
        }

        public static void TestarSuporte(FileInfo arquivo)
        {
            GestorDeImagens.Redimencionar(Image.FromFile(arquivo.FullName), 1, 1);
        }

        public void Fragmentar(Size size, DirectoryInfo pasta, string extensao)
        {
            if (!pasta.Exists) pasta.Create();

            var nomebase = $"{DateTime.Now:yyyyMMddHHmmss}_{{0}}{extensao}";

            var c = 0;

            foreach (var img in GestorDeImagens.Fragmentar(ImagemDeTrabalho, size))
            {
                ImageFormat formato;

                var arquivo = new FileInfo(Path.Combine(pasta.FullName, string.Format(nomebase, c++)));

                switch (arquivo.Extension.ToUpper())
                {
                    case ".JPG":
                        formato = ImageFormat.Jpeg;
                        break;
                    case ".GIF":
                        formato = ImageFormat.Gif;
                        break;
                    case ".PNG":
                        formato = ImageFormat.Png;
                        break;
                    case ".BMP":
                        formato = ImageFormat.Bmp;
                        break;
                    default:
                        throw new Exception("Formato de salvamento inválido!");
                }

                if (arquivo.Exists) arquivo.Delete();

                img.Save(arquivo.FullName, formato);
                img.Dispose();
            }
        }

        public void GirarAngulacao(float angulo, Color cor)
        {
            IniciaProcesso();
            ImagemPrevisualizacao = GestorDeImagens.RotateImg(ImagemPrevisualizacao, angulo, cor);
        }

        public static void VerificaSeGifPodeSerAnimado(FileInfo fileInfo)
        {
            if (!ImageAnimator.CanAnimate(Image.FromFile(fileInfo.FullName)))
                throw new Exception("O GIF não possui quadros de animação!");
        }

        public void DecomporGif()
        {
            IniciaProcesso();
            var imgs = GestorDeImagens.DecomporGif(ImagemPrevisualizacao);
            ImagemPrevisualizacao = GestorDeImagens.UnificarGifDecomposto(imgs);
            GC.SuppressFinalize(imgs);
        }

        public void RunPlugIn(IPlugIn plugIn)
        {
            IniciaProcesso();

            ImagemPrevisualizacao = plugIn.Run((Bitmap)ImagemPrevisualizacao);

            Commit();
        }
    }
}
