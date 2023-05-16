using System;
using System.Drawing;
using Editor_De_Imagens.Servicos;

namespace Editor_De_Imagens.Classes.Acoes
{
    public class Redimencionar : Acao
    {
        private readonly Size? _tamanho;
        private readonly decimal _percentagem;

        public Redimencionar(Size tamanho)
        {
            _tamanho = tamanho;
        }

        public Redimencionar(decimal percentagem)
        {
            _percentagem = percentagem;
            _tamanho = null;
        }

        public override string Executar(Trabalho trabalho)
        {
            try
            {
                var t = _tamanho ?? ObterTamanho(trabalho.ImagemDeTrabalho, _percentagem);

                trabalho.Redimencionar(t.Height, t.Width);
                trabalho.Commit();

                return _tamanho.HasValue ?
                    string.Format("Redimencionado para {0}x{1}.", _tamanho.Value.Width, _tamanho.Value.Height) :
                    string.Format("Redimencionado para {0}% ({1}x{2}).", _percentagem, t.Width, t.Height);
            }
            catch (Exception ex)
            {
                return string.Format("ERRO: {0}.", ex.Message);
            }
        }

        private Size ObterTamanho(Image imagem, decimal percentagem)
        {
            var h = GestorDeCalculo.RegraDe3(100, imagem.Height, percentagem);
            var w = GestorDeCalculo.RegraDe3(100, imagem.Width, percentagem);

            return new Size(w, h);
        }

        public override string ToString()
        {
            return _tamanho == null ?
                string.Format("RESIZE {0}%", _percentagem) :
                string.Format("RESIZE {0} {1}", _tamanho.Value.Width, _tamanho.Value.Height);
        }
    }
}
