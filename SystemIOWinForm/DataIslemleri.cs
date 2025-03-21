using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemIOWinForm
{
    public class DataIslemleri
    {
        public DataIslemleri()
        {

        }

        public List<Personel> PersonelGetir(int adet)
        {
            List<Personel> personelListe = new List<Personel>();

            for (int i = 1; i <= adet; i++)
            {
                Personel personel = new Personel();
                personel.id = i;
                personel.isim = FakeData.NameData.GetFirstName();
                personel.soyisim = FakeData.NameData.GetSurname();
                personel.firmaAdi = FakeData.NetworkData.GetDomain();
                personel.emailadres = personel.isim + "." + personel.soyisim + "@" + personel.firmaAdi;
                personel.ulke = FakeData.PlaceData.GetCounty();
                personelListe.Add(personel);
            }


            return personelListe;
        }

        public void PersonelKaydet(string path, List<Personel> personelListesi)
        {
            foreach (var item in personelListesi)
            {
                if (!Directory.Exists(path + item.ulke))
                {
                    Directory.CreateDirectory(path + item.ulke);
                }
                File.WriteAllText(path + "\\" + item.ulke + "\\" + item.isim + "." + item.soyisim + ".txt"
                    , "Ad: " + item.isim + "\nSoyad: " + item.soyisim + "\nEmail Adres: " + item.emailadres + "\nFirma Adi: " + item.firmaAdi + "\nUlke: " + item.ulke);

            }
        }

    }
}
