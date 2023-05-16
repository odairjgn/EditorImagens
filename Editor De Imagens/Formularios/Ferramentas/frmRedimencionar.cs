using System;
using System.Windows.Forms;
using Editor_De_Imagens.Classes;
using Editor_De_Imagens.Servicos;

namespace Editor_De_Imagens.Formularios.Ferramentas
{
    public partial class frmRedimencionar : Form
    {
        private readonly Trabalho _trabalho;

        public frmRedimencionar(Trabalho trabalho)
        {
            _trabalho = trabalho;
            InitializeComponent();
            nudAltura.Maximum = _trabalho.ImagemPrevisualizacao.Height * 10;
            nudLargura.Maximum = _trabalho.ImagemPrevisualizacao.Width * 10;
            nudAltura.Value = _trabalho.ImagemPrevisualizacao.Height;
            nudLargura.Value = _trabalho.ImagemPrevisualizacao.Width;
        }

        

        private void HabilitaPercentual (bool percentualOn)
        {
            if (percentualOn)
            {
                nudAltura.Enabled = false;
                nudLargura.Enabled = false;
                nudPercentual.Enabled = true;
                ckbProporcao.Enabled = false;
            }
            else
            {
                nudAltura.Enabled = true;
                nudLargura.Enabled = true;
                nudPercentual.Enabled = false;
                ckbProporcao.Enabled = true;
            }
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            try
            {
                _trabalho.Redimencionar(Convert.ToInt32(nudLargura.Value), Convert.ToInt32(nudAltura.Value));
                _trabalho.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Cursor = Cursors.Default;
            Close();
        }

        private void frmRedimencionar_FormClosing(object sender, FormClosingEventArgs e)
        {
            _trabalho.Discard();
        }

        private void rbPercentual_CheckedChanged(object sender, EventArgs e)
        {
            HabilitaPercentual(rbPercentual.Checked);
        }

        private void nudPercentual_ValueChanged(object sender, EventArgs e)
        {
            nudAltura.Value = GestorDeCalculo.RegraDe3(100, _trabalho.ImagemDeTrabalho.Height, nudPercentual.Value);
            nudLargura.Value = GestorDeCalculo.RegraDe3(100, _trabalho.ImagemDeTrabalho.Width, nudPercentual.Value);
        }

        private void nudAltura_ValueChanged(object sender, EventArgs e)
        {
            if (ckbProporcao.Checked)
            {
                nudLargura.Value = GestorDeCalculo.RegraDe3(_trabalho.ImagemDeTrabalho.Height, nudAltura.Value, _trabalho.ImagemDeTrabalho.Width);
            }
        }

        private void nudLargura_ValueChanged(object sender, EventArgs e)
        {
            if (ckbProporcao.Checked)
            {
                nudAltura.Value = GestorDeCalculo.RegraDe3(_trabalho.ImagemDeTrabalho.Width, nudLargura.Value, _trabalho.ImagemDeTrabalho.Height);
            }
        }
    }
}
