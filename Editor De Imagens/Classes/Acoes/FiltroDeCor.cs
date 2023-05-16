using System;
using Editor_De_Imagens.Servicos;

namespace Editor_De_Imagens.Classes.Acoes
{
    public class FiltroDeCor : Acao
    {
        private readonly ColorFilterTypes _filtro;

        public FiltroDeCor(ColorFilterTypes filtro)
        {
            _filtro = filtro;
        }

        public override string Executar(Trabalho trabalho)
        {
            try
            {
                trabalho.FiltroCor(_filtro);
                trabalho.Commit();
                return string.Format("Filtro \"{0}\" aplicado.", _filtro);
            }
            catch (Exception ex)
            {
                return string.Format("ERRO: {0}.", ex.Message);
            }
        }

        public override string ToString()
        {
            return string.Format("COLORFILTER \"{0}\"", _filtro);
        }
    }
}
