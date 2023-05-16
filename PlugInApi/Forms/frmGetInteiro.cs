using System;
using System.Windows.Forms;

namespace PlugInApi.Forms
{
    public partial class frmGetInteiro : Form
    {
        public int Valor { get; set; }

        public frmGetInteiro(string titulo, int min, int max, int def)
        {
            InitializeComponent();
            Valor = def;
            label1.Text = titulo;
            numericUpDown1.Maximum = max;
            numericUpDown1.Minimum = min;

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Valor = Convert.ToInt32(numericUpDown1.Value);
            Close();
        }
    }
}
