using System;

namespace Editor_De_Imagens.Classes.Acoes
{
    public class Negativo : Acao
    {
        public override string Executar(Trabalho trabalho)
        {
            try
            {
                trabalho.AplicaNegativo();
                trabalho.Commit();
                return "Negativo Aplicado.";
            }
            catch (Exception ex)
            {
                return string.Format("ERRO: {0}.", ex.Message);
            }
        }

        public override string ToString()
        {
            return "NEGATIVE";
        }
    }
}
