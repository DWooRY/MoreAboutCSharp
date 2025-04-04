using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerArch
{
    internal class DataAccessLayer
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;

        public DataAccessLayer()
        {
            connection = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
            connection.Open();
        }

        internal void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            else connection.Close();
        }

        internal int AddData(Customer customer)
        {
            // Database icerisine kaydetme islemleri.
            return 1;
        }



    }
}
