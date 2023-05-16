using System;

namespace Editor_De_Imagens.Classes.Acoes
{
    public class Gamma : Acao
    {
        private readonly double _r;
        private readonly double _g;
        private readonly double _b;

        public Gamma(double r, double g, double b)
        {
            _r = r;
            _g = g;
            _b = b;
        }

        public override string Executar(Trabalho trabalho)
        {
            try
            {
                trabalho.Gamma(_r, _g, _b);
                trabalho.Commit();
                return string.Format("Gamma ajustado para RGB: {0}/{1}/{2}.", _r, _g, _b);
            }
            catch (Exception ex)
            {
                return string.Format("ERRO: {0}.", ex.Message);
            }
        }

        public override string ToString()
        {
            return string.Format("GAMMA {0} {1} {2}", _r, _g, _b);
        }
    }
}
