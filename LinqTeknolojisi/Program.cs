using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTeknolojisi
{
    class Program
    {
        static void Main(string[] args)
        {
            dataSource ds = new dataSource();
            List<Musteri> musteriListe = ds.musteriListesi();
            int bulunanToplam = musteriListe.Where(i => i.isim.StartsWith("A")).Count(); // A ile baslayan musteri adlarinin count'unu verir.
            Console.WriteLine(bulunanToplam);

            #region Sorgulama cesitleri
            bulunanToplam = musteriListe.Where(i => i.isim.StartsWith("A")).Count(); // metot to query sorgulama
            //--------------------VEYA-------------------VEYA-------------------VEYA-------------------
            bulunanToplam = (  from I in musteriListe where I.isim.StartsWith("A") select I   ).Count(); //Linq to query sorgulama
            #endregion

            #region Pratice
            int musteriToplam = musteriListe.Where(i => i.isim.StartsWith("A")).Count();

            int musteriToplam2 = musteriListe.Where(i => i.isim.Contains("b") && i.ulke.Contains("a")).Count();

            var musteriBulma =  from I in musteriListe
                                where I.dogumTarih.Year > 1990 && I.isim.Contains("a")
                                select I;

            var musteriBulma2 = from I in musteriListe
                               where I.dogumTarih.Year > 1990 || I.isim.Contains("a")
                               select I;

            #endregion

            #region Quiz
            var musteriBul = from I in musteriListe
                             where I.isim.StartsWith("A") && I.soyisim.Contains("e") && I.dogumTarih.Year > 1985
                             select I;
            //--------------------VEYA-------------------VEYA-------------------VEYA-------------------
            var musteriBul2 = musteriListe.Where(i => i.isim.StartsWith("A") && i.soyisim.Contains("e") && i.dogumTarih.Year > 1985).Select(i => i);

            #endregion

        }


    }
}
