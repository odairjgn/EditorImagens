using System;
using System.Windows.Forms;
using Editor_De_Imagens.Classes;

namespace Editor_De_Imagens.Formularios.Ferramentas
{
    public partial class frmGamma : Form
    {
        private readonly Trabalho _trabalho;

        public frmGamma(Trabalho trabalho)
        {
            _trabalho = trabalho;
            InitializeComponent();
        }

        private void frmGamma_FormClosing(object sender, FormClosingEventArgs e)
        {
            _trabalho.Discard();
        }

        private void trbR_Scroll(object sender, System.EventArgs e)
        {
            lbR.Text = trbR.Value.ToString();
        }

        private void trbG_Scroll(object sender, System.EventArgs e)
        {
            lbG.Text = trbG.Value.ToString();
        }

        private void trbB_Scroll(object sender, System.EventArgs e)
        {
            lbB.Text = trbB.Value.ToString();
        }

        private void btOK_Click(object sender, System.EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            try
            {
                _trabalho.Gamma(trbR.Value, trbG.Value, trbB.Value);
                _trabalho.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Cursor = Cursors.Default;
            Close();
        }
    }
}
