using System;
using System.Windows.Forms;

namespace Editor_De_Imagens.Classes.Acoes
{
    public class CopiarParaAreaDeTransferencia : Acao
    {
        public override string Executar(Trabalho trabalho)
        {
            try
            {
                Clipboard.SetImage(trabalho.ImagemDeTrabalho);
                return "Copiado para área de transferência.";
            }
            catch (Exception ex)
            {
                return string.Format("ERRO: {0}.", ex.Message);
            }
        }

        public override string ToString()
        {
            return "CLIPBOARD";
        }
    }
}
