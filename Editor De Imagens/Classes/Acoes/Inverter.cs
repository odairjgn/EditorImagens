using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Editor_De_Imagens.Classes.Acoes
{
    public class Inverter : Acao
    {
        private readonly string _opcao;

        public Inverter(string opcao)
        {
            _opcao = opcao;
        }

        public override string Executar(Trabalho trabalho)
        {
            try
            {
                RotateFlipType rotacao;

                switch (_opcao.ToUpper())
                {
                    case "V":
                        rotacao = RotateFlipType.RotateNoneFlipY;
                        break;
                    case "H":
                        rotacao = RotateFlipType.RotateNoneFlipX;
                        break;
                    default:
                        throw new Exception(string.Format("Somente valores V/H são permetidos! Valor informado: {0}.", _opcao));
                }

                trabalho.GirarInverter(rotacao);
                trabalho.Commit();

                return string.Format("Inversão {0} aplicada.", rotacao == RotateFlipType.RotateNoneFlipX ? "vertical" : "horizontal");
            }
            catch (Exception ex)
            {
                return string.Format("ERRO: {0}.", ex.Message);
            }
        }

        public override string ToString()
        {
            return string.Format("FLIP {0}", _opcao.ToUpper());
        }
    }
}
