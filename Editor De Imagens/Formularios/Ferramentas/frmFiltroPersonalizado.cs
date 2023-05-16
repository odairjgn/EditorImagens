using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;
using Editor_De_Imagens.Classes;
using Editor_De_Imagens.Servicos;

namespace Editor_De_Imagens.Formularios.Ferramentas
{
    public partial class frmFiltroPersonalizado : Form
    {
        private Trabalho _trabalho;

        public frmFiltroPersonalizado(Trabalho trabalho)
        {
            _trabalho = trabalho;
            InitializeComponent();
            CarregarMatriz(new ColorMatrix());
            Previsualizar();
        }

        public frmFiltroPersonalizado(Trabalho trabalho, Matriz matriz)
        {
            _trabalho = trabalho;
            InitializeComponent();
            CarregarMatriz(new ColorMatrix());
            CarregarMatriz(matriz.Matrix);
            Previsualizar();
        }

        private ColorMatrix ObterMatriz()
        {
            return new ColorMatrix(new[] {
               new []{(float)n00.Value, (float)n01.Value, (float)n02.Value, (float)n03.Value, (float)n04.Value},
               new []{(float)n10.Value, (float)n11.Value, (float)n12.Value, (float)n13.Value, (float)n14.Value},
               new []{(float)n20.Value, (float)n21.Value, (float)n22.Value, (float)n23.Value, (float)n24.Value},
               new []{(float)n30.Value, (float)n31.Value, (float)n32.Value, (float)n33.Value, (float)n34.Value},
               new []{(float)n40.Value, (float)n41.Value, (float)n42.Value, (float)n43.Value, (float)n44.Value}
                });
        }

        private void CarregarMatriz(ColorMatrix matrix)
        {
            n00.Value = (decimal)matrix[0, 0];
            n01.Value = (decimal)matrix[0, 1];
            n02.Value = (decimal)matrix[0, 2];
            n03.Value = (decimal)matrix[0, 3];
            n04.Value = (decimal)matrix[0, 4];

            n10.Value = (decimal)matrix[1, 0];
            n11.Value = (decimal)matrix[1, 1];
            n12.Value = (decimal)matrix[1, 2];
            n13.Value = (decimal)matrix[1, 3];
            n14.Value = (decimal)matrix[1, 4];

            n20.Value = (decimal)matrix[2, 0];
            n21.Value = (decimal)matrix[2, 1];
            n22.Value = (decimal)matrix[2, 2];
            n23.Value = (decimal)matrix[2, 3];
            n24.Value = (decimal)matrix[2, 4];

            n30.Value = (decimal)matrix[3, 0];
            n31.Value = (decimal)matrix[3, 1];
            n32.Value = (decimal)matrix[3, 2];
            n33.Value = (decimal)matrix[3, 3];
            n34.Value = (decimal)matrix[3, 4];

            n40.Value = (decimal)matrix[4, 0];
            n41.Value = (decimal)matrix[4, 1];
            n42.Value = (decimal)matrix[4, 2];
            n43.Value = (decimal)matrix[4, 3];
            n44.Value = (decimal)matrix[4, 4];
        }

        private void Previsualizar()
        {
            try
            {
                pbVisualizar.Image = GestorDeImagens.AplicarMatrix(_trabalho.ImagemDeTrabalho.Clone() as Image, ObterMatriz());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Previsualizar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                sfdSalvar.InitialDirectory = Utils.PastaFiltros.FullName;

                if (sfdSalvar.ShowDialog() != DialogResult.OK) return;

                var m = new Matriz();
                m.Matrix = ObterMatriz();

                GestorXML.Salvar(m, new FileInfo(sfdSalvar.FileName));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ofdAbrir.InitialDirectory = Utils.PastaFiltros.FullName;

                if (ofdAbrir.ShowDialog() != DialogResult.OK) return;

                var m = GestorXML.Obter<Matriz>(new FileInfo(ofdAbrir.FileName));
                CarregarMatriz(m.Matrix);
                Previsualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _trabalho.AplicarMatrix(ObterMatriz());
                _trabalho.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var zip = new MemoryStream(Properties.Resources.Filtros);
            var zipf = new ZipArchive(zip, ZipArchiveMode.Read);

            var temp = new DirectoryInfo(Path.Combine(Utils.PastaFiltros.FullName, "_temp"));

            if (temp.Exists)
                temp.Delete();

            if (!temp.Exists)
                temp.Create();

            zipf.ExtractToDirectory(temp.FullName);

            var copy = temp.GetFiles();

            foreach (var c in copy)
            {
                File.Copy(c.FullName, Path.Combine(Utils.PastaFiltros.FullName, c.Name), true);
            }

            Directory.Delete(temp.FullName, true);

            MessageBox.Show("Arquivos exemplos extraídos na galeria de filtros!");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var f = new frmGaleriaFiltros();

            if (f.ShowDialog() == DialogResult.OK)
            {
                CarregarMatriz(f.Matriz.Matrix);
            }
        }


    }
}
