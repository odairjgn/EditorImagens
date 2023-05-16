using System;
using System.IO;

namespace Editor_De_Imagens.Classes.Acoes
{
    public class Salvar : Acao
    {
        private readonly FileInfo _arquivo;

        public Salvar(FileInfo arquivo)
        {
            _arquivo = arquivo;
        }

        public override string Executar(Trabalho trabalho)
        {
            try
            {
                if (_arquivo.Exists) _arquivo.Delete();

                trabalho.Salvar(_arquivo);

                return string.Format("Salvo com sucesso em \"{0}\".", _arquivo.FullName);
            }
            catch (Exception ex)
            {
                return string.Format("ERRO: {0}", ex.Message);
            }
        }

        public override string ToString()
        {
            return string.Format("SAVE \"{0}\"", _arquivo.FullName);
        }
    }
}
