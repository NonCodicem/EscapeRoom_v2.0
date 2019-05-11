using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeRoom_v1._0
{
    class Room
    {
        public string Name { get; }
        public string Description { get; set; }
        public List<Item> Items { get; set; } = new List<Item>();

        public Room(string nm, string desc)
        {
            Name = nm;
            Description = desc;
        }
    }
}
