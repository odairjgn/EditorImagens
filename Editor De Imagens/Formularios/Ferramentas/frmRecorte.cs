using System;
using System.Windows.Forms;
using Editor_De_Imagens.Classes;
using Editor_De_Imagens.Servicos;

namespace Editor_De_Imagens.Formularios.Ferramentas
{
    public partial class frmRecorte : Form
    {
        private readonly Trabalho _trabalho;
        private int _largura;
        private int _altura;

        public frmRecorte(Trabalho trabalho, FormWindowState estado = FormWindowState.Maximized)
        {
            _trabalho = trabalho;
            InitializeComponent();
            WindowState = estado;

            nudAcima.Maximum = nudAbaixo.Maximum = _trabalho.ImagemDeTrabalho.Height;
            nudEsquerda.Maximum = nudDireita.Maximum = _trabalho.ImagemDeTrabalho.Width;
            _altura = _trabalho.ImagemDeTrabalho.Height;
            _largura = _trabalho.ImagemDeTrabalho.Width;
            lbTamano.Text = string.Format("{0} x {1}", _largura, _altura);
            pbImg.Image = _trabalho.ImagemDeTrabalho;
        }

        private void AtualizaLabelTamanho()
        {
            lbTamano.Text = string.Format("{0} x {1}", _largura - nudDireita.Value - nudEsquerda.Value, _altura - nudAcima.Value - nudAbaixo.Value);
            DesenhaRecorte();
        }

        private void DesenhaRecorte()
        {
            pbImg.Image = GestorDeImagens.DesenharPrevisualizacaoDeCorte(
                _trabalho.ImagemDeTrabalho,
                Convert.ToInt32(nudEsquerda.Value),
                Convert.ToInt32(nudAcima.Value),
                _largura - Convert.ToInt32(nudEsquerda.Value) - Convert.ToInt32(nudDireita.Value),
                _altura - Convert.ToInt32(nudAcima.Value) - Convert.ToInt32(nudAbaixo.Value)
                );

        }

        private void nudAcima_ValueChanged(object sender, System.EventArgs e)
        {
            nudAbaixo.Maximum = _altura - nudAcima.Value - 1;
            AtualizaLabelTamanho();
        }

        private void nudEsquerda_ValueChanged(object sender, System.EventArgs e)
        {
            nudDireita.Maximum = _largura - nudEsquerda.Value - 1;
            AtualizaLabelTamanho();
        }

        private void nudDireita_ValueChanged(object sender, System.EventArgs e)
        {
            nudEsquerda.Maximum = _largura - nudDireita.Value - 1;
            AtualizaLabelTamanho();
        }

        private void nudAbaixo_ValueChanged(object sender, System.EventArgs e)
        {
            nudAcima.Maximum = _altura - nudAbaixo.Value - 1;
            AtualizaLabelTamanho();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            _trabalho.Recortar(Convert.ToInt32(nudEsquerda.Value),
                Convert.ToInt32(nudAcima.Value),
                _largura - Convert.ToInt32(nudEsquerda.Value) - Convert.ToInt32(nudDireita.Value),
                _altura - Convert.ToInt32(nudAcima.Value) - Convert.ToInt32(nudAbaixo.Value));

            _trabalho.Commit();
            Close();
        }
        
    }
}
