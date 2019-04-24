using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace YuGiOhDeckBuilder
{
    class CardParser : ICardParser
    {
        public List<string> SerialiseCardsToCsv(List<ICard> cards)
        {
            List<string> csvLines = new List<string>();

            foreach (ICard card in cards)
            {
                List<string> properties = new List<string>()
                {
                    card.Name,
                    card.Attribute,
                    card.Type,
                    card.Level,
                    card.Attack,
                    card.Defense
                };

                csvLines.Add(string.Join(",", properties));
            }
            return csvLines;
        }
    }
}
