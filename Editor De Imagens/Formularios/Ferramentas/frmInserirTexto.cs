using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;
using Editor_De_Imagens.Classes;
using Editor_De_Imagens.Servicos;

namespace Editor_De_Imagens.Formularios.Ferramentas
{
    public partial class frmInserirTexto : Form
    {
        private Trabalho _trabalho;

        public frmInserirTexto(Trabalho trabalho)
        {
            _trabalho = trabalho;
            InitializeComponent();
            cbCor1.DataSource = ObterCores();
            cbCor2.DataSource = ObterCores();
            cbFonte.DataSource = ObterFontes();
            cbEstilo.DataSource = ObterEstilos();
        }

        private void Visualizar()
        {
            pbImg.Image = GestorDeImagens.InserirTexto(_trabalho.ImagemDeTrabalho.Clone() as Image, txtTexto.Text, Convert.ToInt32(nudX.Value), Convert.ToInt32(nudY.Value), cbFonte.Text, float.Parse(nudTamanho.Text), cbEstilo.Text, cbCor1.Text, cbCor2.Text);
        }

        private List<string> ObterEstilos()
        {
            return Enum.GetNames(typeof (FontStyle)).ToList();
        } 

        private List<string> ObterFontes()
        {
            return new InstalledFontCollection().Families.Select(f => f.Name).ToList();
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
            try
            {
                _trabalho.InserirTexto(txtTexto.Text, Convert.ToInt32(nudX.Value), Convert.ToInt32(nudY.Value), cbFonte.Text, float.Parse(nudTamanho.Text), cbEstilo.Text, cbCor1.Text, cbCor2.Text);
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

        
        private void nud_ValueChanged(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Visualizar();
        }
    }
}
