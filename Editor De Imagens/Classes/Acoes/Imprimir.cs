using System;
using System.Drawing.Printing;

namespace Editor_De_Imagens.Classes.Acoes
{
    public class Imprimir : Acao
    {
        private readonly PrinterSettings _printer;

        public Imprimir(PrinterSettings printer)
        {
            _printer = printer;
        }

        public override string Executar(Trabalho trabalho)
        {
            try
            {
                trabalho.Imprimir(_printer);
                return string.Format("Impresso em \"{0}\".", _printer.PrinterName);
            }
            catch (Exception ex)
            {
                return string.Format("ERRO: {0}", ex.Message);
            }
        }

        public override string ToString()
        {
            return string.Format("PRINT \"{0}\"", _printer.PrinterName);
        }
    }
}
