using System.Collections.Generic;
using Microsoft.VisualBasic.FileIO;

namespace YuGiOhDeckBuilder
{
    class CsvReader : ICsvReader
    {
        public List<string> Read(TextFieldParser parser)
        {
            List<string> csv = new List<string>();

            using (parser)
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                parser.TrimWhiteSpace = true;

                while (!parser.EndOfData)
                {
                    csv.Add(parser.ReadLine());
                }
            }

            return csv;
        }
    }
}
