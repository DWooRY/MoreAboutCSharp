using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SystemIO.DirectoryIslemleri
{
    class Program
    {
        static void Main(string[] args)
        {

            //YeniKlasorOlustur("C:\\Users\\Administrator\\Desktop\\Deneme");  //Masaustune deneme adinda klasor olusturuyor.
            //KlasorVarlikKontrolu("C:\\Users\\Administrator\\Desktop\\Deneme") //Masaustunde deneme adinda klasor var mi onu sorguluyor.
            //KlasorSilme("C:\\Users\\Administrator\\Desktop\\Deneme") //Masaustundeki deneme adindaki klasoru siler.
            //KlasorTasima("C:\\Udemy", "C:\\Users\\Administrator\\Desktop\\"); //C'deki Udemy Klasorunu masaustune tasir.
        }

        static void YeniKlasorOlustur(string path)
        {
            DirectoryInfo D1 = Directory.CreateDirectory(path); //path'e deneme adinda klasor olusturuyor. Klasorun kendisini donuyor. Ne zaman olusturuldu...
        }

        static void KlasorVarlikKontrolu(string path)
        {
            bool kontrol = Directory.Exists(path); //path'de adini verdigimiz ilgili klasor var mi diye sorguluyor bool deger donuyor.
        }

        static void KlasorSilme(string path)
        {
            //Directory.Delete(path); //path'de adini verdigimiz ilgili klasoru içi boş ise siler.
            Directory.Delete(path, true); //path'de adini verdigimiz ilgili klasoru icindekilerle birlikte siler.
        }

        static void KlasorTasima(string source, string direction)
        {
            Directory.Move(source, direction); //source'daki dosyayi direction'daki pathe tasir.
        }



        static void Odev1()
        {
            string path = "C:\\Udemy";
            if (Directory.Exists(path))
            {
                Directory.Delete(path, true);
                Directory.CreateDirectory(path);
                Console.WriteLine("C klasörü içerisindeki Udemy klasörü silindi. Sonrasında tekrar oluşturuldu.");

            }
            else
            {
                Directory.CreateDirectory(path);
                Console.WriteLine("C sürücüsü içerisine Udemy klasörü oluşturuldu.");
            }
        }


    }
}
