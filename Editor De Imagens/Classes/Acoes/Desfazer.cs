using System;

namespace Editor_De_Imagens.Classes.Acoes
{
    public class Desfazer : Acao
    {
        public override string Executar(Trabalho trabalho)
        {
            try
            {
                trabalho.Desfazer();
                trabalho.Commit();

                return "Ação desfeita.";
            }
            catch (Exception ex)
            {
                return string.Format("ERRO: {0}.", ex.Message);
            }
        }

        public override string ToString()
        {
            return "UNDO";
        }
    }
}
