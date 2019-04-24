using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YuGiOhDeckBuilder
{
    public class MonsterCard : ICard
    {
        public string Name { get; set; }
        public string Level { get; set; }
        public string Type { get; set; }
        public string Attack { get; set; }
        public string Defense { get; set; }
        public string Rarity { get; set; }
        public string CardText { get; set; }
        public string Serial { get; set; }
        
    }
}
