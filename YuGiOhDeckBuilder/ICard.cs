using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YuGiOhDeckBuilder
{
    public interface ICard
    {
        string Name { get; set; }
        string Attribute { get; set; }
        string Type { get; set; }
        string Level { get; set; }
        string Attack { get; set; }
        string Defense { get; set; }
    }
}
