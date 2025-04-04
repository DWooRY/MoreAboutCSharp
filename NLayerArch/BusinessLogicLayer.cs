using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerArch
{
    internal class BusinessLogicLayer
    {
        DataAccessLayer DAL;

        public BusinessLogicLayer()
        {
            DAL = new DataAccessLayer();
        }

        internal int AddData(int cusId, string name, string surname)
        {
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(surname))
            {
                Customer customer = new Customer();
                customer.ID = cusId;
                customer.Name = name;
                customer.Surname = surname;
                return DAL.AddData(customer);
            }
            else return -1;

        }

    }
}
