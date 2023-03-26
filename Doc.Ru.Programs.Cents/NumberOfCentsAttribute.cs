using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doc.Ru.Programs.Cents
{
    public class NumberOfCentsAttribute:Attribute
    {
        public uint Cents { get; }

        public NumberOfCentsAttribute(){}

        public NumberOfCentsAttribute(uint number)
        {
            Cents = number;
        }
    }
}
