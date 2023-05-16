using System;
namespace Editor_De_Imagens.Classes.Acoes
{
    public class Brilho : Acao
    {
        private readonly int _brilho;

        public Brilho(int brilho)
        {
            _brilho = brilho;
        }

        public override string Executar(Trabalho trabalho)
        {
            try
            {
                trabalho.Brilho(_brilho);
                trabalho.Commit();

                return string.Format("Brilho alterado para {0}.", _brilho);
            }
            catch (Exception ex)
            {
                return string.Format("ERRO: {0}.", ex.Message);
            }
        }

        public override string ToString()
        {
            return string.Format("BRIGHTNESS {0}", _brilho);
        }
    }
}
