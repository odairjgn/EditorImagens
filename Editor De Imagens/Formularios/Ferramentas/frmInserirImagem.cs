using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Editor_De_Imagens.Classes;
using Editor_De_Imagens.Servicos;

namespace Editor_De_Imagens.Formularios.Ferramentas
{
    public partial class frmInserirImagem : Form
    {
        private Trabalho _trabalho;
        private Image _img;

        public frmInserirImagem(Trabalho trabalho)
        {
            InitializeComponent();
            _trabalho = trabalho;
            nudX.Maximum = _trabalho.ImagemDeTrabalho.Width;
            nudY.Maximum = _trabalho.ImagemDeTrabalho.Height;
        }

        private void Visualizar()
        {
            try
            {
                pbImg.Image = GestorDeImagens.InserirImage((Image)_trabalho.ImagemDeTrabalho.Clone(), (Image)_img.Clone(), Convert.ToInt32(nudX.Value), Convert.ToInt32(nudY.Value));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ofdAbrir.ShowDialog() != DialogResult.OK) return;

            _img = Image.FromFile(ofdAbrir.FileName);
            Visualizar();
        }



        private void frmInserirImagem_Load(object sender, EventArgs e)
        {
            pbImg.Image = _trabalho.ImagemDeTrabalho;
        }

        private void nudX_ValueChanged(object sender, EventArgs e)
        {
            if (_img != null) Visualizar();
        }

        private void nudY_ValueChanged(object sender, EventArgs e)
        {
            if (_img != null) Visualizar();
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            if (_img != null)
            {
                try
                {
                    _trabalho.InserirImagem(_img, Convert.ToInt32(nudX.Value), Convert.ToInt32(nudY.Value));
                    _trabalho.Commit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            Close();
        }
    }
}
