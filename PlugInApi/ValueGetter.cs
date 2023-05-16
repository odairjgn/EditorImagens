using System.Collections.Generic;
using PlugInApi.Forms;

namespace PlugInApi
{
    public enum UiForNumber
    {
        NumericUpDown,
        TextBox,
        Slider
    }

    public class ValueGetter
    {
        public static int SolicitarInteiro(string titulo, int min, int max, int defaultvalue)
        {
            var f = new frmGetInteiro(titulo, min, max, defaultvalue);
            f.ShowDialog();
            return f.Valor;
        }

        public static T SolicitarItemDaColecao<T>(string titulo, List<T> itens, T defaultvalue)
        {
            return default(T);
        }
    }
}
