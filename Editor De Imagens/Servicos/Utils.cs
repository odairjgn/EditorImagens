using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using Editor_De_Imagens.Classes;
using PlugInApi;

namespace Editor_De_Imagens.Servicos
{
    public class Utils
    {
        public static Image ObterPreviewDeFiltro(ColorMatrix matrix)
        {
            try
            {
                var _trabalho = new Trabalho(Properties.Resources.exemplo);

                return GestorDeImagens.AplicarMatrix(_trabalho.ImagemDeTrabalho.Clone() as Image, matrix);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static DirectoryInfo PastaTrabalho
        {
            get
            {
                var dir = new DirectoryInfo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "BCEditorImagens"));

                if (!dir.Exists)
                    dir.Create();

                return dir;
            }
        }

        public static DirectoryInfo PastaFiltros
        {
            get
            {
                var dir = new DirectoryInfo(Path.Combine(PastaTrabalho.FullName, "Filtros"));

                if (!dir.Exists)
                    dir.Create();

                return dir;
            }
        }

        public static DirectoryInfo PastaPlugIns
        {
            get
            {
                var dir = new DirectoryInfo(Path.Combine(PastaTrabalho.FullName, "PlugIn"));

                if (!dir.Exists)
                    dir.Create();

                return dir;
            }
        }

        public static List<IPlugIn> Plugins { get; set; }
    }
}
