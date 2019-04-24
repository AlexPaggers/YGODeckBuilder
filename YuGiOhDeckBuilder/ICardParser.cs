using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YuGiOhDeckBuilder
{
    public interface ICardParser
    {
        List<string> SerialiseCardsToCsv(List<ICard> cards);
    }
}
