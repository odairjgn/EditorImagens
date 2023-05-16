namespace Editor_De_Imagens.Classes.Acoes
{
    public abstract class Acao 
    {
        public abstract string Executar(Trabalho trabalho);
        public abstract override string ToString();
    }
}
