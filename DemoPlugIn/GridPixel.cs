using System.Drawing;
using PlugInApi;
using PlugInApi.ObjetosDeValor;

namespace DemoPlugIn
{
    public class GridPixel : IPlugIn
    {
        public PlugInInfo GetInfo()
        {
            return new PlugInInfo()
            {
                Nome = "Grid Pixel",
                Autor = "Odair",
                Contato = "odairjgn@outlook.com",
                Descricao = "Cria efeito pixelado por grid",
                Versao = "1.0",
                Icone = Recursos.icons8_Data_Grid_50
            };
        }

        public Bitmap Run(Bitmap original)
        {
            int fator = ValueGetter.SolicitarInteiro("Número de píxels", 2, 50, 3);

            var temp = new Bitmap(original, original.Width * fator, original.Height * fator);
            Graphics g = Graphics.FromImage(temp);
            g.Clear(Color.Transparent);

            for (int i = 0; i < original.Width; i++)
            {
                for (int j = 0; j < original.Height; j++)
                {
                    var color = original.GetPixel(i, j);
                    var p = new Pen(color);
                    var r = new Rectangle(i * fator, j * fator, fator, fator);
                    g.DrawRectangle(p, r);
                }
            }

            return temp;
        }
    }
}
