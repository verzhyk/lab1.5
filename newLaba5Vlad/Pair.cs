using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newLaba5Vlad
{
    public class Pair : Fraction
    {
        public Pair(int first, double second)
        {
            First = first;
            Second = second;
        }
        public override bool Compare(Fraction f)
        {
            if (First == f.First || First > f.First)
            {
                if (Second > f.Second) return true;
                else return false;
            }
            else return false;
        }
    }
}
