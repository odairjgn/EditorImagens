using System.Drawing;
using System.Windows.Forms;
using Editor_De_Imagens.Classes;

namespace Editor_De_Imagens.Componentes
{
    public class FiltroButtom : Button
    {
        public FiltroButtom(Matriz matriz, string name)
        {
            Matriz = matriz;
            Size = new Size(100, 100);
            Image = Matriz.Miniatura;
            Text = name;
            Font = new Font(new FontFamily("Arial"), 10);
            ForeColor = Color.White;
        }

        public Matriz Matriz { get; private set; }
    }
}
