using System.Drawing;
using System.Drawing.Imaging;
using Editor_De_Imagens.Servicos;

namespace Editor_De_Imagens.Classes
{
    public class Matriz
    {
        public float[] Linha1 { get; set; }
        public float[] Linha2 { get; set; }
        public float[] Linha3 { get; set; }
        public float[] Linha4 { get; set; }
        public float[] Linha5 { get; set; }

        public Image Miniatura
        {
            get { return Utils.ObterPreviewDeFiltro(Matrix); }
        }


        public ColorMatrix Matrix
        {
            get
            {
                return new ColorMatrix(new[] { Linha1, Linha2, Linha3, Linha4, Linha5 });
            }
            set
            {
                Linha1 = new[] { value[0, 0], value[0, 1], value[0, 2], value[0, 3], value[0, 4] };
                Linha2 = new[] { value[1, 0], value[1, 1], value[1, 2], value[1, 3], value[1, 4] };
                Linha3 = new[] { value[2, 0], value[2, 1], value[2, 2], value[2, 3], value[2, 4] };
                Linha4 = new[] { value[3, 0], value[3, 1], value[3, 2], value[3, 3], value[3, 4] };
                Linha5 = new[] { value[4, 0], value[4, 1], value[4, 2], value[4, 3], value[4, 4] };
            }
        }

        public Matriz()
        {
            Linha1 = new[] { 0f, 0f, 0f, 0f, 0f };
            Linha2 = new[] { 0f, 0f, 0f, 0f, 0f };
            Linha3 = new[] { 0f, 0f, 0f, 0f, 0f };
            Linha4 = new[] { 0f, 0f, 0f, 0f, 0f };
            Linha5 = new[] { 0f, 0f, 0f, 0f, 0f };
        }
    }
}
