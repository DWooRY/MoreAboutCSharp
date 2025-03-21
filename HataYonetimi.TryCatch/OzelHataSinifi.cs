using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HataYonetimi.TryCatch
{
    public class OzelHataSinifi : Exception
    {
        public void ozelHataSinifi()
        {
            Console.WriteLine("Ozel hata sinifi");
        }


    }
}
