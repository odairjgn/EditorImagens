using System.Windows.Forms;
using Editor_De_Imagens.Classes;

namespace Editor_De_Imagens.Formularios.Ferramentas
{
    public partial class frmContraste : Form
    {
        private readonly Trabalho _trabalho;

        public frmContraste(Trabalho trabalho)
        {
            _trabalho = trabalho;
            InitializeComponent();
        }

        private void btOK_Click(object sender, System.EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            try
            {
                _trabalho.Contraste(trbValor.Value);
                _trabalho.Commit();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Cursor = Cursors.Default;

            Close();
        }

        private void frmContraste_FormClosing(object sender, FormClosingEventArgs e)
        {
            _trabalho.Discard();
        }

        private void trbValor_Scroll(object sender, System.EventArgs e)
        {
            lbValor.Text = trbValor.Value.ToString();
        }
    }
}
