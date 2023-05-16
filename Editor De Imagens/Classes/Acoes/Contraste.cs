using System;

namespace Editor_De_Imagens.Classes.Acoes
{
    class Contraste : Acao
    {
        private readonly double _contraste;

        public Contraste(double contraste)
        {
            _contraste = contraste;
        }

        public override string Executar(Trabalho trabalho)
        {
            try
            {
                trabalho.Contraste(_contraste);
                trabalho.Commit();

                return string.Format("Contraste ajustado para {0}.", _contraste);
            }
            catch (Exception ex)
            {
                return string.Format("ERRO: {0}.", ex.Message);
            }
        }

        public override string ToString()
        {
            return string.Format("CONTRAST {0}", _contraste);
        }
    }
}
