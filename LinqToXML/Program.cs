using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqToXML
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             <?xml version="1.0" encoding="utf-8" standalone="yes"?>
             <VeriTabanim>
                 +Yorum Eklendi
                 <Personellerim ID="102">
                     <Isim>Enis</Isim>
                     <Soyisim>Yildiz</Soyisim>
                     <EmailAdres>eniscanyildiz@gmail.com</EmailAdres>
                 </Personellerim>
             </VeriTabanim>
             */

            //XDocument xDoc = new XDocument(new XDeclaration("1.0", "UTF-8", "yes"),
            //    new XElement("VeriTabanim",
            //    new XComment("Personellerim Bilgilerini Tasir"),
            //        new XElement("Personellerim", new XAttribute("ID", "102"),
            //            new XElement("Isim", "Enis"), new XElement("Soyisim", "Yildiz"), new XElement("EmailAdres", "eniscanyildiz@gmail.com"))));
            //xDoc.Save(@"C:\XML\Ornek2.xml");



            //--------------------------------------------------------------------------------------------------------------

            //Olusturma

            //List<Students> students = new List<Students>();
            //for (int i = 1; i <= 100; i++)
            //{
            //    Students temp = new Students();
            //    temp.ID = Guid.NewGuid();
            //    temp.Name = FakeData.NameData.GetFirstName();
            //    temp.Surname = FakeData.NameData.GetSurname();
            //    temp.Number = FakeData.NumberData.GetNumber(100, 500);
            //    students.Add(temp);
            //}

            //XDocument xDoc = new XDocument(new XDeclaration("1.0", "UTF-8", "yes"),
            //    new XElement("Students", students.Select(I =>
            //    new XElement("Student", new XElement("ID", I.ID),
            //    new XElement("Name", I.Name),
            //    new XElement("Surname", I.Surname),
            //    new XElement("Number", I.Number)))));
            //xDoc.Save(@"C:\XML\Students.xml");


            //Okuma
            //XDocument DocRead = XDocument.Load(@"C:\XML\Students.xml");
            //DocRead.Descendants("Student").ToList().ForEach(I =>
            //{
            //    Console.WriteLine("ID: " + I.Element("ID").Value);
            //    Console.WriteLine("Name: " + I.Element("Name").Value);
            //    Console.WriteLine("Surname: " + I.Element("Surname").Value);
            //    Console.WriteLine("Number: " + I.Element("Number").Value);
            //    Console.WriteLine("************************************");
            //});


        }
    }
}
