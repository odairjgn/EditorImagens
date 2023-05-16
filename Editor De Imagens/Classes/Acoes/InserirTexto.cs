using System;

namespace Editor_De_Imagens.Classes.Acoes
{
    public class InserirTexto : Acao
    {
        private readonly string _texto;
        private readonly int _x;
        private readonly int _y;
        private readonly string _font;
        private readonly float _tamanho;
        private readonly string _stilo;
        private readonly string _cor1;
        private readonly string _cor2;

        public InserirTexto(string texto, int x, int y, string font, float tamanho, string stilo, string cor1, string cor2)
        {
            _texto = texto;
            _x = x;
            _y = y;
            _font = font;
            _tamanho = tamanho;
            _stilo = stilo;
            _cor1 = cor1;
            _cor2 = cor2;
        }

        public override string Executar(Trabalho trabalho)
        {
            try
            {
                trabalho.InserirTexto(_texto, _x, _y, _font, _tamanho, _stilo, _cor1, _cor2);
                trabalho.Commit();

                return string.Format("Texto \"{0}\" inserido em x:{1}/y:{2} Formatação:{3}({4})-{5}-{6}/{7}.",
                    _texto,
                    _x,
                    _y,
                    _font,
                    _tamanho,
                    _stilo,
                    _cor1,
                    _cor2);
            }
            catch (Exception ex)
            {
                return string.Format("ERRO: {0}.", ex.Message);
            }
        }

        public override string ToString()
        {
            return string.Format("TEXT \"{0}\" {1} {2} \"{3}\" {4} \"{5}\" \"{6}\" \"{7}\"",
                _texto, _x, _y, _font, _tamanho, _stilo, _cor1, _cor2);
        }
    }
}
