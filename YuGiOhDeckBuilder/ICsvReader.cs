using Microsoft.VisualBasic.FileIO;
using System.Collections.Generic;

namespace YuGiOhDeckBuilder
{
    interface ICsvReader
    {
        List<string> Read(TextFieldParser parser);
    }
}
