using System.Collections.Generic;
using System.IO;

namespace YuGiOhDeckBuilder
{
    public interface ICsvWriter
    {
        bool Write(StreamWriter stream, List<string> csv);
    }
}