using System;
using System.Drawing;
using System.Linq;

namespace Editor_De_Imagens.Servicos
{
    public class GestorDeCalculo
    {
        public static int RegraDe3(decimal termoX, decimal equivalenteX, decimal termoY)
        {
            var equivalenteY = (equivalenteX * termoY) / termoX;

            var x = (int)Math.Round(equivalenteY, 0, MidpointRounding.AwayFromZero);

            return x <= 0 ? 1 : x;
        }

        public static Size CalculaZoom(Size tamanhoOriginal, int zoom)
        {
            var w = RegraDe3(100, tamanhoOriginal.Width, zoom);
            var h = RegraDe3(100, tamanhoOriginal.Height, zoom);

            return new Size(w, h);
        }

        public static Size AjustarAltura(Size tamanhoOriginal, Rectangle area)
        {
            var fator = RegraDe3(tamanhoOriginal.Height, 100, area.Height);

            var w = RegraDe3(100, tamanhoOriginal.Width, fator);
            var h = RegraDe3(100, tamanhoOriginal.Height, fator);

            return new Size(w, h);
        }

        public static Size AjustarLargura(Size tamanhoOriginal, Rectangle area)
        {
            var fator = RegraDe3(tamanhoOriginal.Width, 100, area.Width);

            var w = RegraDe3(100, tamanhoOriginal.Width, fator);
            var h = RegraDe3(100, tamanhoOriginal.Height, fator);

            return new Size(w, h);
        }

        public static Size AjustarParaCaber(Size tamanhoOriginal, Rectangle area)
        {
            var fatorLargura = RegraDe3(tamanhoOriginal.Width, 100, area.Width);
            var fatorAltura = RegraDe3(tamanhoOriginal.Height, 100, area.Height);
            return CalculaZoom(tamanhoOriginal, new[] { fatorAltura, fatorLargura }.Min());
        }
    }
}
