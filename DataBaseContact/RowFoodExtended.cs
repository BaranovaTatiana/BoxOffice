using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseContact
{
    public class RowFoodExtended
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Color { get; set; }
        public string Type { get; set; }

        public int Count = 1;
        public RowFoodExtended(int id, string name, string type, string color, double price)
        {
            Id = id;
            Name = name;
            Price = price;
            Color = color;
            Type = type;
        }

        public override string ToString()
        {

            return Name + " " + Price +" рублей "+ Count +" штуки";
        }
    }
}
