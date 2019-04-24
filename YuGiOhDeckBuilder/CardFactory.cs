using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YuGiOhDeckBuilder
{
    class CardFactory : IFactory<ICard>
    {
        public ICard CreateFromCsv(List<string> properties)
        {
            return new Card
            {
                Name = properties[CardConstants.Name],
                Attribute = properties[CardConstants.Attribute],
                Type = properties[CardConstants.Type],
                Level = properties[CardConstants.Level],
                Attack = properties[CardConstants.Atk],
                Defense = properties[CardConstants.Def]
            };
        }
    }
}
