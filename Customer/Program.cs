using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly  Lib = Assembly.LoadFile(@"C:\Users\user\source\repos\CustomerLibrary\bin\Debug\CustomerLibrary.dll");
            Type[] tp = Lib.GetTypes();

        }
    }
}
