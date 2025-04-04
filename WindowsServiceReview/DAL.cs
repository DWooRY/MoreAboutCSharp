using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsServiceReview
{
    public class DAL
    {
        SqlConnection con;
        SqlCommand cmd;
        int result;

        public DAL()
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=WindowsServiceReview;Integrated Security=True");
        }

        public int Insert(string Event, DateTime Date)
        {
            try
            {
                cmd = new SqlCommand("INSERT INTO DailyEvent (Event, Date) VALUES (@Event, @Date)", con);
                cmd.Parameters.AddWithValue("@Event", Event);
                cmd.Parameters.AddWithValue("@Date", Date);
                con.Open();
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
            return result;
        }






    }
}
