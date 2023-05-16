using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Editor_De_Imagens.Classes;

namespace Editor_De_Imagens.Formularios.Ferramentas
{
    public partial class frmBrilho : Form
    {
        private readonly Trabalho _trabalho;

        public frmBrilho(Trabalho trabalho)
        {
            _trabalho = trabalho;
            InitializeComponent();
        }

        private void trbValor_Scroll(object sender, EventArgs e)
        {
            lbValor.Text = trbValor.Value.ToString();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            try
            {
                _trabalho.Brilho(trbValor.Value);
                _trabalho.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Cursor = Cursors.Default;

            Close();
        }

        private void frmBrilho_FormClosing(object sender, FormClosingEventArgs e)
        {
            _trabalho.Discard();
        }
    }
}
