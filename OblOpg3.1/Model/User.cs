namespace OblOpg3._1.Model
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Password { get; set; }

        public User(string password, string name) 
        {
            Name = name;
            Password = password;
        }
        public User(int id, string password, string name)
        {
            Id = id;
            Name = name;
            Password = password;
        }

        public User()
        {
            Id = 0;
            Name = null;
            Password = null;
        }
    }
}