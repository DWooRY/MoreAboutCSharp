using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateNedir
{
    class Program
    {

        delegate void MatematikselIslemler(int s1, int s2);
        delegate void EkranaYaz(string d1, string d2);

        static void Topla(int s1, int s2)
        {
            Console.WriteLine("Toplama = " + (s1 + s2));
        }
        static void Cikart(int s1, int s2)
        {
            Console.WriteLine("Cikarma = " + (s1 - s2));
        }
        static void Carp(int s1, int s2)
        {
            Console.WriteLine("Carpma = " + (s1 * s2));
        }

        static void Main(string[] args)
        {
            MatematikselIslemler mat1 = new MatematikselIslemler(Topla);
            mat1 += Carp;
            mat1 += Cikart;

            mat1.Invoke(30, 2);

            Delegate[] isaretEdilenMetotlar = mat1.GetInvocationList();

            mat1 -= Carp;
            Console.ReadLine();





            //Delegate ile isimsiz metot kullanimi
            EkranaYaz Test1 = new EkranaYaz(delegate (string isim, string soyisim)
            {
                Console.WriteLine(isim+" "+soyisim);
            });

            //Lambda Exp Kullanimi
            EkranaYaz Test2 = (string isim, string soyisim) =>
            {
                Console.WriteLine(isim + " " + soyisim);
            };

            Test1("Enis", "Yildiz");

            Test2("Sevda", "Yildiz");

        }
    }
}
