using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemIO.FileIslemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileCreate("C:\\Udemy\\merhaba.txt"); //C'deki Udemy klasorunun icine merhaba adinda txt dosyasi olusturur.
            //bool kontrol = FileExists("C:\\Udemy\\merhaba.txt");//C'deki Udemy klasorunde merhaba.txt dosyasi var mi yok mu kontrol eder. bool doner.
            //FileDelete("C:\\Udemy\\merhaba.txt"); //C'deki Udemy klasorundeki merhaba.txt dosyasini siler.
            //FileMove("C:\\Udemy\\merhaba.txt", "C:\\Users\\Administrator\\Desktop\\")//merhaba.txt'yi masaustune tasir.
            //FileMove("C:\\Udemy\\merhaba.txt", "C:\\Users\\Administrator\\Desktop\\")//merhaba.txt'yi masaustune kopyalar.
            //FileAppendText("C:\\Udemy\\merhaba.txt", "merhaba.txt'nin Icerisine bu yaziyi yaz.");//dosyanin icerisine girilen yaziyi/degeri yazar.
            //FileReadAllText("C:\\Udemy\\merhaba.txt");//methaba.txt'nin icerisindekileri okur. CW ile ekrana yazdirilabilir.
        }

        static void FileCreate(string path)
        {
            FileStream Fs = File.Create(path);//path'de ilgili dosyayi olusturur.
            Fs.Close(); //ilgili dosyayi kapatir. Eger kapatmazsak uygulama acik kaldigi surece bellekte kalir. Yapilmazsa farkli hatalar alinabilir.
        }

        static bool FileExists(string path)
        {
            return File.Exists(path);//Ilgili path'de dosya varmi yok mu kontrol eder. Bool deger doner.
        }

        static void FileDelete(string path)
        {
            File.Delete(path);//Ilgili path'de dosyayi siler.
        }

        static void FileMove(string source, string destination)
        {
            File.Move(source, destination);//Ilgili source'dan destination'a dosyayi tasir.
        }

        static void FileCopy(string source, string destination)
        {
            File.Copy(source, destination);//Ilgili source'dan destination'a dosyayi kopyalar.
        }

        static void FileAppendText(string source, string text)
        {
            File.AppendAllText(source, text);// source'daki dosyanin icerisine text'de yazan yaziyi/degeri yazar.
        }

        static void FileReadAllText(string path)
        {
            File.ReadAllText(path);//path'in hedefledigi dosyanin degerlerini okur.
        }
    }
}
