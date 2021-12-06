using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseContact
{
    public class RowFood
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int ColorId { get; set; }
        public int TypeId { get; set; }

        public RowFood(string name, int typeId, int colorId, double price)
        {
            Id = -1;
            Name = name;
            Price = price;
            ColorId = colorId;
            TypeId = typeId;
        }

        public RowFood(int id, string name, int typeId, int colorId, double price)
        {
            Id = id;
            Name = name;
            Price = price;
            ColorId = colorId;
            TypeId = typeId;
        }

        public static bool Equals(RowFood rf1, RowFood rf2)
        {
            return rf1.Id == rf2.Id && 
                   rf1.Name == rf2.Name &&
                   rf1.ColorId == rf2.ColorId && 
                   rf1.TypeId==rf2.TypeId &&
                   Math.Abs(rf1.Price - rf2.Price) < 0.0001;
        }

        public static bool operator ==(RowFood rf1, RowFood rf2)
        {
            return Equals(rf1, rf2);
        }

        public static bool operator !=(RowFood rf1, RowFood rf2)
        {
            return !Equals(rf1, rf2);
        }
    }
}
