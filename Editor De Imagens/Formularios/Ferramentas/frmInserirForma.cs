using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Editor_De_Imagens.Classes;
using Editor_De_Imagens.Servicos;

namespace Editor_De_Imagens.Formularios.Ferramentas
{
    public partial class frmInserirForma : Form
    {
        private Trabalho _trabalho;

        public frmInserirForma(Trabalho trabalho)
        {
            _trabalho = trabalho;
            InitializeComponent();
            cbCor.DataSource = ObterCores();
        }

        private void Visualizar()
        {
            FormaGeometrica forma;

            if (rbRetanguloPreenchido.Checked)
                forma = FormaGeometrica.RetanguloPreenchido;
            else if (rbElipse.Checked)
                forma = FormaGeometrica.Circulo;
            else if (rbElipseSolida.Checked)
                forma = FormaGeometrica.CirculoPreenchido;
            else
                forma = FormaGeometrica.Retangulo;

            pbImg.Image = GestorDeImagens.InserirFormaGeometrica(_trabalho.ImagemDeTrabalho.Clone() as Image, forma, Convert.ToInt32(nudX.Value), Convert.ToInt32(nudY.Value), Convert.ToInt32(nudLargura.Value), Convert.ToInt32(nudAltura.Value), cbCor.Text);
        }


        private List<string> ObterCores()
        {
            KnownColor[] colors = (KnownColor[])Enum.GetValues(typeof(KnownColor));
            //foreach (KnownColor knowColor in colors)
            //{
            //    Color color = Color.FromKnownColor(knowColor);
            //}

            return colors.Select(c => c.ToString()).ToList();
        }
        
        private void btInserir_Click(object sender, EventArgs e)
        {
            FormaGeometrica forma;

            if (rbRetanguloPreenchido.Checked)
                forma = FormaGeometrica.RetanguloPreenchido;
            else if (rbElipse.Checked)
                forma = FormaGeometrica.Circulo;
            else if (rbElipseSolida.Checked)
                forma = FormaGeometrica.CirculoPreenchido;
            else
                forma = FormaGeometrica.Retangulo;

            try
            {
                _trabalho.InserirForma(forma, Convert.ToInt32(nudX.Value), Convert.ToInt32(nudY.Value), Convert.ToInt32(nudLargura.Value), Convert.ToInt32(nudAltura.Value), cbCor.Text);
                _trabalho.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Close();
        }

        private void frmInserirForma_Load(object sender, EventArgs e)
        {
            Visualizar();
        }

        private void rbRetangulo_CheckedChanged(object sender, EventArgs e)
        {
            Visualizar();
        }

        private void rbElipse_CheckedChanged(object sender, EventArgs e)
        {
            Visualizar();
        }

        private void rbRetanguloPreenchido_CheckedChanged(object sender, EventArgs e)
        {
            Visualizar();
        }

        private void rbElipseSolida_CheckedChanged(object sender, EventArgs e)
        {
            Visualizar();
        }

        private void nudX_ValueChanged(object sender, EventArgs e)
        {
            Visualizar();
        }

        private void nudY_ValueChanged(object sender, EventArgs e)
        {
            Visualizar();
        }

        private void nudLargura_ValueChanged(object sender, EventArgs e)
        {
            Visualizar();
        }

        private void nudAltura_ValueChanged(object sender, EventArgs e)
        {
            Visualizar();
        }
        
        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbCor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Visualizar();
        }
    }
}
