using System;
using System.Windows.Forms;
using Editor_De_Imagens.Classes;

namespace Editor_De_Imagens.Formularios.Ferramentas
{
    public partial class frmDesfoque : Form
    {
        private readonly Trabalho _trabalho;

        public frmDesfoque(Trabalho trabalho)
        {
            _trabalho = trabalho;
            InitializeComponent();
        }

        private void frmDesfoque_FormClosing(object sender, FormClosingEventArgs e)
        {
            _trabalho.Discard();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            try
            {
                _trabalho.Desfoque(Convert.ToInt32(nudValor.Value));
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
