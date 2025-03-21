using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region String Interpolition
            string isim = "Enis", soyisim = "Yildiz";


            Console.WriteLine($"Merhaba {isim} {soyisim}");
            #endregion

            #region 'Var'
            var meslek = "Bilgisayar Programcisi"; //otomatik string oldu.
            var yas = 15; //otomatik int oldu
            var kilo = 85.4; //otomatik double oldu
            #endregion

            #region Var 'Isimsiz Tip'
            var Ogrenci = new
            {
                numara = 1,
                isim = "enis",
                soyisim = "yildiz"
            };

            Console.WriteLine(Ogrenci.isim);

            #endregion

            #region Local Function
            //Metot icerisinde metot yazimi.

            //Bu bir local functiondur. Sadece icerisinde bulundugu metotdan cagirilabilir.
            int toplama(int n1, int n2)
            {
                return n1 + n2;
            }

            Console.WriteLine(toplama(15, 27));


            #endregion

            #region Try - Catch - When
            try
            {
                //throw new Exception();
                throw new Exception("Format Hatasi");
            }
            catch (Exception ex) when (ex.Message == "Format Hatasi")
            {

            }
            catch (Exception ex)
            {

                throw;
            }

            #endregion

            #region Tuple

            Tuple<string, string, int, int, int> tupleOrnegi = new Tuple<string, string, int, int, int>("Enis", "Yildiz", 21, 193, 95);

            Console.WriteLine(tupleOrnegi.Item1 + tupleOrnegi.Item2);


            #endregion

            #region dynamic
            //dynamic tip farketmeksizin her turlu tipi alir.
            dynamic deger = "Enis";
            deger = 12;
            deger = true;


            #endregion

        }

        #region Metot parametrelerine default deger atama
        public int Carpma(int s1, int s2 = 1)
        {
            return s1 * s2;
        }
        #endregion
    }
}
