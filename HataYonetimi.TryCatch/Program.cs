using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HataYonetimi.TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {



        }

        static void HataYonetimi()
        {
            try
            {
                Console.Write("Bir sayi girin: ");
                int s1 = int.Parse(Console.ReadLine());

                if (s1 == 0)
                {
                    throw new OzelHataSinifi();
                }

            }
            catch (OzelHataSinifi fx)
            {
                Console.WriteLine("ozel hata sinifi cath icinde yakalandi");
            }
            catch (FormatException fx)
            {
                Console.WriteLine("Sayisal deger giriniz");
                Console.WriteLine(fx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }


    }
}
