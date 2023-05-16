using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Editor_De_Imagens.Classes;
using Editor_De_Imagens.Servicos;

namespace Editor_De_Imagens.Formularios.Tarefas
{
    public partial class frmFragmentar : Form
    {
        private Trabalho _trabalho;
        private int _imgs;
        private bool _lock;

        public frmFragmentar(Trabalho trabalho)
        {
            _trabalho = trabalho;
            _imgs = 0;
            InitializeComponent();

            nudAltura.Maximum = _trabalho.ImagemDeTrabalho.Height;
            nudLargura.Maximum = _trabalho.ImagemDeTrabalho.Width;

            nudAltura.Value = nudAltura.Maximum > 5 ? 5 : nudAltura.Maximum;
            nudLargura.Value = nudLargura.Maximum > 5 ? 5 : nudLargura.Maximum;

            cbFormato.SelectedIndex = 0;
        }

        private void nudAltura_ValueChanged(object sender, System.EventArgs e)
        {
            DesenharPrevisualizacao();
        }

        private void nudLargura_ValueChanged(object sender, System.EventArgs e)
        {
            DesenharPrevisualizacao();
        }

        private void DesenharPrevisualizacao()
        {
            pbImg.Image = GestorDeImagens.DesenharPrevisualizacaoFragmentacao(_trabalho.ImagemDeTrabalho, new Size((int) nudLargura.Value, (int) nudAltura.Value),ref _imgs);

            lbTamano.Text = $"{_imgs} imagem(ns).";
        }

        private void btOK_Click(object sender, System.EventArgs e)
        {
            var fold = new FolderBrowserDialog();

            if (fold.ShowDialog() != DialogResult.OK) return;

            pbWait.Visible = true;
            pbWait.Invalidate();

            var th = new Thread(() =>
            {
                _lock = true;
                btOK.Enabled = nudAltura.Enabled = nudLargura.Enabled = cbFormato.Enabled = false;
                var pasta = new DirectoryInfo(fold.SelectedPath);

                _trabalho.Fragmentar(new Size((int)nudLargura.Value, (int)nudAltura.Value), pasta, cbFormato.Text);
                _lock = false;

                MessageBox.Show("Concluído!", "Informação");
                Close();
            });

            th.Start();
        }

        private void frmFragmentar_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = _lock;
        }
    }
}
