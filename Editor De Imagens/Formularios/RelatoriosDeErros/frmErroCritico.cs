using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Editor_De_Imagens.Formularios.RelatoriosDeErros
{
    public partial class frmErroCritico : Form
    {
        public frmErroCritico(Exception ex)
        {
            InitializeComponent();
            lbMensagem.Text = ex.Message;
            lbPilha.Text = ex.StackTrace;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo(string.Format("mailto:odairjgn@outlook.com?subject=Relatório de erros: {0}&body=Pilha: {1}", lbMensagem.Text, lbPilha.Text)));
        }
    }
}
