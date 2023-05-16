using System.Collections.Generic;
using Editor_De_Imagens.Classes.Acoes;

namespace Editor_De_Imagens.Classes
{
    public class FilaDeAcoes
    {
        public Queue<Acao> Acoes { get; set; }
        public Trabalho Trabalho { get; set; }
        public Delegates.Delegates.MetodoLog Log { get; set; }

        public void ExecutarScript()
        {
            while (Acoes.Count > 0)
            {
                Log(Acoes.Dequeue().Executar(Trabalho));
            }
        }

        public FilaDeAcoes(Trabalho trabalho, Delegates.Delegates.MetodoLog log)
        {
            Acoes = new Queue<Acao>();
            Trabalho = trabalho;
            Log = log;
        }

        public void GravarPasso(Acao acao)
        {
            Acoes.Enqueue(acao);
        }
    }
}
