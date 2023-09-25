using OblOpg3._1.Model;
using System.Data.SqlClient;

namespace OblOpg3._1.Repository
{
    public class UserRepository
    {
        private static List<User> users = new List<User>();

        public void GetAllUsers()
        {
            string SQLServerDBConnectionString = "server=mssql16.unoeuro.com;uid=olivur_dk;pwd=9zRBH62Fhfn5tpdeGb3y;database=olivur_dk_db_data_";

            using (SqlConnection connection = new SqlConnection(SQLServerDBConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Users", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            users.Add(new User(reader.GetInt32(0), reader.GetString(1), reader.GetString(2)));
                        }
                    }
                }
            }
        }

        public bool CheckValidUser(User user)
        {
            bool valid = false;
            foreach (User u in users)
            {
                if(u.Name == user.Name && u.Password == user.Password)
                {
                    user.Id = u.Id;
                    valid = true;
                }
            }
            return valid;
        }
    }
}
