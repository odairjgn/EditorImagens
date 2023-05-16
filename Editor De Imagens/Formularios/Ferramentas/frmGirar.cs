using System;
using System.Drawing;
using System.Windows.Forms;

namespace Editor_De_Imagens.Formularios.Ferramentas
{
    public partial class frmGirar : Form
    {
        public float Angulo { get; set; }
        public Color Cor { get; set; }

        public frmGirar()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Angulo = (float)numericUpDown1.Value;
            Cor = pnCor.BackColor;
            DialogResult = Angulo != 0f ? DialogResult.OK : DialogResult.Cancel;
        }

        private void btSelCor_Click(object sender, EventArgs e)
        {
            if (cdCor.ShowDialog() == DialogResult.OK)
            {
                pnCor.BackColor = cdCor.Color;
            }
        }
    }
}
