using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YuGiOhDeckBuilder
{
    public class Card : ICard
    {
        public string Name { get; set; }
        public string Attribute { get; set; }
        public string Type { get; set; }
        public string Level { get; set; }
        public string Attack { get; set; }
        public string Defense { get; set; }
    }
}
