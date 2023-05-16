using System;

namespace Editor_De_Imagens.Classes.Acoes
{
    public class Refazer : Acao
    {
        public override string Executar(Trabalho trabalho)
        {
            try
            {
                trabalho.Refazer();
                trabalho.Commit();

                return "Ação refeita.";
            }
            catch (Exception ex)
            {
                return string.Format("ERRO: {0}.", ex.Message);
            }
        }

        public override string ToString()
        {
            return "REDO";
        }
    }
}
