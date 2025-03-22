using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SystemXMLKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            XmlTextWriter xmlText = new XmlTextWriter(@"C:\XML\Personellerim.xml", System.Text.UTF8Encoding.UTF8);
            xmlText.WriteComment("Xml Islemleri");
            xmlText.WriteStartElement("Personellerim");

            xmlText.WriteStartElement("Personel");
            xmlText.WriteAttributeString("ID", "1");
            xmlText.WriteElementString("Isim", "Enis");
            xmlText.WriteElementString("Soyisim", "Yildiz");
            xmlText.WriteElementString("EmailAdres", "eniscanyildiz@gmail.com");
            xmlText.WriteEndElement();

            xmlText.WriteStartElement("Personel");
            xmlText.WriteAttributeString("ID", "2");
            xmlText.WriteElementString("Isim", "Sude");
            xmlText.WriteElementString("Soyisim", "Yildiz");
            xmlText.WriteElementString("EmailAdres", "sudeyildiz@gmail.com");
            xmlText.WriteEndElement();

            xmlText.WriteEndElement();
            xmlText.Close();
            */



            XmlReader xmlRead = XmlReader.Create(@"C:\XML\Personellerim.xml");
            while (xmlRead.Read())
            {
                Console.WriteLine($"{xmlRead.Name.ToString()} {xmlRead.Value.ToString()}");
            }




        }
    }
}
