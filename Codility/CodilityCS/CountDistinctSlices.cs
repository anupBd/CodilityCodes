using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityCS
{
    class CountDistinctSlices
    {
        List<int> pairs = new List<int>();

        public int solution(int M, int[] A)
        {
            var MAX_SLICES = 1000000000;
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = i; j < A.Length; j++)
                {
                    
                }
            }

            return pairs.Count;
        }
    }

    class Pair
    {
        public int First { get; set; }
        public int Second { get; set; }
    }
}
