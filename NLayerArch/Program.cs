using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerArch
{
    class Program
    {
        static void Main(string[] args)
        {
            // UI
            BusinessLogicLayer BLL = new BusinessLogicLayer();
            BLL.AddData(1, "Enis", "Yildiz");
        }
    }
}
