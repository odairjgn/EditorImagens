using System;
using System.Drawing;

namespace Editor_De_Imagens.Classes
{
    public class ItemHistorico
    {
        public Image Imagem { get; set; }
        public DateTime DataHora { get; set; }

        public ItemHistorico(Image imagem)
        {
            Imagem = imagem;
            DataHora = DateTime.Now;
        }
    }
}
