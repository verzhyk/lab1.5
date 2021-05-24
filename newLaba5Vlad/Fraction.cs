using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newLaba5Vlad
{
    public abstract class Fraction
    {
        public int First { get; set; }
        public double Second { get; set; }

        public abstract bool Compare(Fraction f);
    }
}
