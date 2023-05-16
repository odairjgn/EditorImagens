using System;
using System.Collections.Generic;
using System.Linq;

namespace Editor_De_Imagens.Classes
{
    public class Historico
    {
        private const int NumeroMaximoDePassosMemorizados = 50;
        private DateTime _dataBase;
        public List<ItemHistorico> Itens { get; private set; }

        public Historico()
        {
            Itens = new List<ItemHistorico>();
            _dataBase = new DateTime();
        }

        public void AddPasso(ItemHistorico item)
        {
            if (Itens.Count >= NumeroMaximoDePassosMemorizados)
            {
                var itensRemover = Itens.OrderBy(i => i.DataHora).Take((Itens.Count + 1) - NumeroMaximoDePassosMemorizados);
                itensRemover.AsParallel().ForAll(i => Itens.Remove(i));
            }

            Itens.Add(item);
            _dataBase = item.DataHora;
        }

        public bool HaComoDesfazer { get { return Itens.Any(i => i.DataHora < _dataBase); } }
        public bool HaComoRefazer { get { return Itens.Any(i => i.DataHora > _dataBase); } }

        public ItemHistorico Desfazer()
        {
            var retorno = Itens.OrderByDescending(i => i.DataHora).FirstOrDefault(i => i.DataHora < _dataBase);
            if (retorno != null) _dataBase = retorno.DataHora;
            return retorno;
        }

        public ItemHistorico Refazer()
        {
            var retorno = Itens.OrderBy(i => i.DataHora).FirstOrDefault(i => i.DataHora > _dataBase);
            if (retorno != null) _dataBase = retorno.DataHora;
            return retorno;
        }
    }
}
