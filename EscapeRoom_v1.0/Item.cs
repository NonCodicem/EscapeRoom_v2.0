using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeRoom_v1._0
{
    class Item
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsLocked { get; set; } = false;
        public bool IsPortable { get; set; }
        public Item Key { get; set; }
        public Item HiddenItem { get; set; }

        public Item(string nm, string desc)
        {
            Name = nm;
            Description = desc;
            IsPortable = false;
        }

        public override string ToString()
        {
            return Name;
        }

    }
}
