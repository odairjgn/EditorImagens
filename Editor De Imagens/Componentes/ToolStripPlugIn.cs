using System;
using System.Drawing;
using System.Windows.Forms;

namespace Editor_De_Imagens.Componentes
{
    public class ToolStripPlugIn : ToolStripMenuItem
    {
        public ToolStripPlugIn(string texto, Image ico, int indexplugin, EventHandler click):base(texto, ico, click)
        {
            IndexPlugin = indexplugin;
        }

        public int IndexPlugin { get; }
    }
}
