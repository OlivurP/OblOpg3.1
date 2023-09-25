using OblOpg3._1.Model;
using System.Data.SqlClient;

namespace OblOpg3._1.Repository
{
    public class KurvRepository
    {
        public List<Kurv> GetAllItems(int userId)
        {
            List<Kurv> kurvList = new List<Kurv>();
            string SQLServerDBConnectionString = "server=mssql16.unoeuro.com;uid=olivur_dk;pwd=9zRBH62Fhfn5tpdeGb3y;database=olivur_dk_db_data_";

            using (SqlConnection connection = new SqlConnection(SQLServerDBConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Kurv \n WHERE BrugerId = " + userId, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            kurvList.Add(new Kurv(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2)));
                        }
                    }
                }
            }
            return kurvList;
        }

        public void AddToKurv(int userId, int frugtId)
        {
            string SQLServerDBConnectionString = "server=mssql16.unoeuro.com;uid=olivur_dk;pwd=9zRBH62Fhfn5tpdeGb3y;database=olivur_dk_db_data_";

            using (SqlConnection connection = new SqlConnection(SQLServerDBConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO Kurv(VareId, BrugerId) \nVALUES(" + frugtId + ", " + userId + ")", connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
