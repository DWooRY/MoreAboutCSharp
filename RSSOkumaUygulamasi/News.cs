using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSOkumaUygulamasi
{
    public class News
    {
        public string Header { get; set; }
        public string Link { get; set; }
        public string Details { get; set; }

        public override string ToString()
        {
            return Header;
        }
    }
    
}
