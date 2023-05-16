using System;
using System.Threading;
using System.Windows.Forms;
using Editor_De_Imagens.Classes;
using Editor_De_Imagens.Componentes;
using Editor_De_Imagens.Servicos;

namespace Editor_De_Imagens.Formularios.Ferramentas
{
    public partial class frmGaleriaFiltros : Form
    {
        public delegate void Inv();
        public Matriz Matriz { get; set; }

        public frmGaleriaFiltros()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }


        private void frmGaleriaFiltros_Load(object sender, EventArgs e)
        {
            Inv inv = () =>
            {
                    var pasta = Utils.PastaFiltros;

                    var filtros = pasta.GetFiles("*.xmlmat");

                    foreach (var f in filtros)
                    {
                        var name = f.Name.Replace(f.Extension, "");
                        var bt = new FiltroButtom(GestorXML.Obter<Matriz>(f), name);
                        bt.Click += bt_Click;
                        tt.SetToolTip(bt, name);
                        pnFiltros.Controls.Add(bt);
                    }
                
            };

            Invoke(inv);
        }


        void bt_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Matriz = (sender as FiltroButtom).Matriz;
            Close();
        }
    }
}
