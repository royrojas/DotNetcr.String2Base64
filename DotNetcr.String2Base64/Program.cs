using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetcr.String2Base64
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string texto = "Texto de ejemplo";                              
                Console.WriteLine("Texto Original: " + texto);
                Console.WriteLine();
                string textoBase64 = EncodeStrToBase64(texto);
                Console.WriteLine("Texto a Base64: " + textoBase64);
                Console.WriteLine();
                Console.WriteLine("Base64 a String: " + DecodeBase64ToString(textoBase64));
                Console.Read();
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine("======================");
                Console.WriteLine("Error: " + e.Message);
                Console.WriteLine("======================");
                Console.Read();
            }
        }

        /// <summary>
        /// Convierte string en Base64 a texto
        /// </summary>
        /// <param name="valor">Valor a reemplazar</param>
        /// <returns></returns>
        public static string DecodeBase64ToString(string valor)
        {
            byte[] myBase64ret = Convert.FromBase64String(valor);
            string myStr = System.Text.Encoding.UTF8.GetString(myBase64ret);
            return myStr;
        }

        /// <summary>
        /// Convierte texto string en Base64
        /// </summary>
        /// <param name="valor">Valor a reemplazar</param>
        /// <returns></returns>
        public static string EncodeStrToBase64(string valor)
        {
            byte[] myByte = System.Text.Encoding.UTF8.GetBytes(valor);
            string myBase64 = Convert.ToBase64String(myByte);
            return myBase64;
        }

        /// <summary>
        /// Convierte string en Base64 a XMLDocument
        /// </summary>
        /// <param name="valor">Valor a reemplazar</param>
        /// <returns></returns>
        public static System.Xml.XmlDocument DecodeBase64ToXML(string valor)
        {
            byte[] myBase64ret = Convert.FromBase64String(valor);
            string myStr = System.Text.Encoding.UTF8.GetString(myBase64ret);
            System.Xml.XmlDocument xmlDoc = new System.Xml.XmlDocument();
            xmlDoc.LoadXml(myStr);
            return xmlDoc;
        }

    }
}
