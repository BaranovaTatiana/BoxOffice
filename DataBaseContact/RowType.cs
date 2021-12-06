using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseContact
{
    public class RowType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public RowType(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
