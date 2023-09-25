namespace OblOpg3._1.Model
{
    public class Kurv
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int FrugtId { get; set; }

        public Kurv(int id, int userId, int frugtId) 
        {
            Id = id;
            UserId = userId;
            FrugtId = frugtId;
        }
    }
}
