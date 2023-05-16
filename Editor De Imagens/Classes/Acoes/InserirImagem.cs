using System;
using System.Drawing;
using System.IO;

namespace Editor_De_Imagens.Classes.Acoes
{
    public class InserirImagem : Acao
    {
        private readonly FileInfo _imagem;
        private readonly int _x;
        private readonly int _y;

        public InserirImagem(FileInfo imagem, int x, int y)
        {
            _imagem = imagem;
            _x = x;
            _y = y;
        }

        public override string Executar(Trabalho trabalho)
        {
            try
            {
                var img = Image.FromFile(_imagem.FullName);

                trabalho.InserirImagem(img, _x, _y);
                trabalho.Commit();

                return string.Format("Imagem \"{0}\" inserida em x:{1}/y:{2}.", _imagem.FullName, _x, _y);
            }
            catch (Exception ex)
            {
                return string.Format("ERRO: {0}.", ex.Message);
            }
        }

        public override string ToString()
        {
            return string.Format("IMAGE \"{0}\" {1} {2}", _imagem.FullName, _x, _y);
        }
    }
}
