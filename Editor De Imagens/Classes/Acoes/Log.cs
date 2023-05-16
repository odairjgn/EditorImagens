namespace Editor_De_Imagens.Classes.Acoes
{
    public class Log : Acao
    {
        private readonly string _log;

        public Log(string log)
        {
            _log = log;
        }

        public override string Executar(Trabalho trabalho)
        {
            return _log;
        }

        public override string ToString()
        {
            return string.Format("LOG \"{0}\"", _log);
        }
    }
}
