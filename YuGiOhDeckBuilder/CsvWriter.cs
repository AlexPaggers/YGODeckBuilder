using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YuGiOhDeckBuilder
{
    class CsvWriter : ICsvWriter
    {
        public bool Write(StreamWriter stream, List<string> lines)
        {
            using (stream)
            {
                foreach (var line in lines)
                {
                    stream.WriteLine(line);
                }
            }

            return true;
        }
    }
}
