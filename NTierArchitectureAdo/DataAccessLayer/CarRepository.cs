using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class CarRepository
    {
        public int InsertCar(Cars c)
        {
            string sorgu = "insert into Arabas(Marka,Model,KapiSayisi)values(@Ma,@Mo,@KaSa)";
            using (SqlConnection cnn = new SqlConnection(Connection.CS))
            {
                SqlCommand cmd = new SqlCommand(sorgu, cnn);
                cnn.Open();
                cmd.Parameters.AddWithValue("@Ma", c.Brand);
                cmd.Parameters.AddWithValue("@Mo", c.Model);
                cmd.Parameters.AddWithValue("@KaSa", c.KapiSayisi);

                return cmd.ExecuteNonQuery();
            }
        }
    }
}
