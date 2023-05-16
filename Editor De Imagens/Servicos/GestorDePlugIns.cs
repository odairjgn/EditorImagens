using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using PlugInApi;

namespace Editor_De_Imagens.Servicos
{
    public class GestorDePlugIns
    {
        public static List<IPlugIn> CarregarTodosPlugIns()
        {
            var dlls = Utils.PastaPlugIns.GetFiles("*.dll");

            var pi = new List<IPlugIn>();
            foreach (var dll in dlls)
            {
                try
                {
                    pi.AddRange(CarregarDll<IPlugIn>(dll));
                }
                catch (Exception)
                {
                }
            }
            return pi;
        }

        private static List<T> CarregarDll<T>(FileInfo dll)
        {
            var ass = Assembly.LoadFile(dll.FullName);
            var types = ass.GetTypes().Where(t => t.GetInterfaces().Contains(typeof(T)));

            var lista = new List<T>();
            foreach (var t in types)
            {
                try
                {
                    var objeto = (T)Activator.CreateInstance(t);
                    lista.Add(objeto);
                }
                catch (Exception)
                {
                }
            }
            return lista;
        }
    }
}
