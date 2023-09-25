using OblOpg3._1.Model;
using System.Data.SqlClient;
using System.Drawing;

namespace OblOpg3._1.Repository
{
    public class FrugtRepository
    {

        
        public List<Frugt> GetAllFrugt()
        {

            List<Frugt> frugter = new List<Frugt>();
            string SQLServerDBConnectionString = "server=mssql16.unoeuro.com;uid=olivur_dk;pwd=9zRBH62Fhfn5tpdeGb3y;database=olivur_dk_db_data_";

            using (SqlConnection connection = new SqlConnection(SQLServerDBConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Frugt", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            frugter.Add(new Frugt(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDouble(3), reader.GetString(4)));
                        }
                    }
                }
            }
            return frugter;
        }
    }
}
