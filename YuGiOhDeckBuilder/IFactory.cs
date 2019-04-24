using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YuGiOhDeckBuilder
{
    interface IFactory<T>
    {
        T CreateFromCsv(List<string> properties);
    }
}