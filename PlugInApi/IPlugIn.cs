using System.Drawing;
using PlugInApi.ObjetosDeValor;

namespace PlugInApi
{
    public interface IPlugIn
    {
        PlugInInfo GetInfo();
        Bitmap Run(Bitmap original);
    }
}
