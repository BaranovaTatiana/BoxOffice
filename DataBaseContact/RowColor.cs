using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseContact
{
    public class RowColor
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public RowColor(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
