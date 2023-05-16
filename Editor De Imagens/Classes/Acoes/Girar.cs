using System;
using System.Drawing;

namespace Editor_De_Imagens.Classes.Acoes
{
    public class Girar : Acao
    {
        private readonly int _angulacao;

        public Girar(int angulacao)
        {
            _angulacao = angulacao;
        }

        public override string Executar(Trabalho trabalho)
        {
            try
            {
                RotateFlipType rotacao;

                switch (_angulacao)
                {
                    case 90:
                        rotacao = RotateFlipType.Rotate90FlipNone;
                        break;
                    case 180:
                        rotacao = RotateFlipType.Rotate180FlipNone;
                        break;
                    case 270:
                        rotacao = RotateFlipType.Rotate270FlipNone;
                        break;
                    default:
                        throw new Exception(string.Format("Somente valores 90, 180, 270 são permetidos! Valor informado: {0}.", _angulacao));
                }

                trabalho.GirarInverter(rotacao);
                trabalho.Commit();

                return string.Format("Rotação de {0}° aplicada.", _angulacao);
            }
            catch (Exception ex)
            {
                return string.Format("ERRO: {0}.", ex.Message);
            }
        }

        public override string ToString()
        {
            return string.Format("ROTATE {0}", _angulacao);
        }
    }
}
