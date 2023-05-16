using System;
using System.IO;
using System.Xml.Serialization;

namespace Editor_De_Imagens.Servicos
{
    public class GestorXML
    {
        public static void Salvar(object objeto, FileInfo arquivo)
        {
            if (arquivo.Exists) arquivo.Delete();

            var xml = new XmlSerializer(objeto.GetType());
            var stream = new StreamWriter(arquivo.FullName);
            xml.Serialize(stream, objeto);
            stream.Close();
        }

        public static T Obter<T>(FileInfo arquivo) where T : class 
        {
            if (!arquivo.Exists)
                throw new Exception("Arquivo inexistente!");

            var xml = new XmlSerializer(typeof (T));
            var stream = new StreamReader(arquivo.FullName);
            var retorno = xml.Deserialize(stream) as T;
            stream.Close();
            return retorno;
        }
    }
}
