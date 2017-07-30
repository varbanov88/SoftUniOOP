using System.Collections.Generic;

namespace StrategyPattern.Comparatos
{
    class AgeComparator : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Age - y.Age;
        }
    }
}
