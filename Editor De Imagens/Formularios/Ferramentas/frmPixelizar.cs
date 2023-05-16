using System;
using System.Windows.Forms;
using Editor_De_Imagens.Classes;

namespace Editor_De_Imagens.Formularios.Ferramentas
{
    public partial class frmPixelizar : Form
    {
        private Trabalho _trabalho;

        public frmPixelizar(Trabalho trabalho)
        {
            _trabalho = trabalho;
            InitializeComponent();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            try
            {
                _trabalho.Pixalizar(Convert.ToInt32(nudFator.Value));
                _trabalho.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Cursor = Cursors.Default;
            Close();
        }

        private void frmPixelizar_FormClosing(object sender, FormClosingEventArgs e)
        {
            _trabalho.Discard();
        }
    }
}
