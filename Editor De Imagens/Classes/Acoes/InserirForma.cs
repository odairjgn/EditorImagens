using System;
using Editor_De_Imagens.Servicos;

namespace Editor_De_Imagens.Classes.Acoes
{
    public class InserirForma : Acao
    {
        private readonly FormaGeometrica _forma;
        private readonly int _x;
        private readonly int _y;
        private readonly int _largura;
        private readonly int _altura;
        private readonly string _cor;

        public InserirForma(FormaGeometrica forma, int x, int y, int largura, int altura, string cor)
        {
            _forma = forma;
            _x = x;
            _y = y;
            _largura = largura;
            _altura = altura;
            _cor = cor;
        }

        public override string Executar(Trabalho trabalho)
        {
            try
            {
                trabalho.InserirForma(_forma, _x, _y, _largura, _altura, _cor);
                trabalho.Commit();

                return string.Format("Forma \"{0} {1}x{2} x:{3}/y:{4} \"{5}\" inserida.",
                    _forma, _largura, _altura, _x, _y, _cor);
            }
            catch (Exception ex)
            {
                return string.Format("ERRO: {0}.", ex.Message);
            }
        }

        public override string ToString()
        {
            return string.Format("FORM \"{0}\" {1} {2} {3} {4} \"{5}\"",
                _forma,
                _x,
                _y,
                _largura,
                _altura,
                _cor);
        }
    }
}
