using System.Collections.Generic;
using System.Linq;

namespace Linq_Tutorial_1
{
    class Linq
    {
        private List<int> arr;

        public Linq()
        {
            arr = (new int[] { 0, 5, 12, 15, 5, 11, 7, 23, 5, 1, 5, 3, 7 }).ToList();
        }

        public int arrayMax()
        {
            return arr.Max();
        }

        public int[] whereLessThan(int i)
        {
            return (from a in arr where a < i select  a).ToArray();
        }

        public int[] whereGreaterThan(int i)
        {
            return (from a in arr where a > i select a).ToArray();
        }

        public bool exists(int i)
        {
            return arr.Any(a => i == a);
        }

        public int amount(int i)
        {
            return (from a in arr where a == i select a).Count();
        }

        public bool addIfNotExists(int i)
        {
            if (!arr.Any(a => i == a))
            {
                arr.Add(i);
                return true;
            }
            return false;
        }
    }
}
