using System;
using System.Windows.Forms;
using Editor_De_Imagens.Formularios;
using Editor_De_Imagens.Formularios.RelatoriosDeErros;

namespace Editor_De_Imagens
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            try
            {
                Application.Run(new Principal());
            }
            catch (Exception ex)
            {
                new frmErroCritico(ex).ShowDialog();
            }
        }
    }
}
