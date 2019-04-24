using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YuGiOhDeckBuilder
{
    class DeckWriter : ICsvWriter
    {
        public bool Write(StreamWriter stream, List<string> deck)
        {
            using (stream)
            {
                foreach (var property in deck)
                {
                    stream.WriteLine(string.Join(",", property));
                }
            }

            return true;
        }
    }
}
