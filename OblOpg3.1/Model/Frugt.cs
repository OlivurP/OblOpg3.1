using System.Drawing;

namespace OblOpg3._1.Model
{
    public class Frugt
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public string? Image { get; set; }

        public Frugt(int id, string name, string description, double price, string image) 
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            Image = image;
        }
        public Frugt() 
        {
            Id = 0;
            Name = null;
            Description = null;
            Price = 0;
            Image = null;
        }
    }
}
