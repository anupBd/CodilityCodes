using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityCS
{
    class PassingCars
    {
        public int solution(int[] A)
        {
            int count = 0;
            List<long> positions = new List<long>();
            long[] prefixSum = PrefixSum(A, positions);
            for (var i = 0; i < positions.Count; i++)
            {
                count += (int) (prefixSum[A.Length] - prefixSum[positions[i]]);
            }
            return count;
        }

        public long[] PrefixSum(int[] array, List<long> positions)
        {
            long[] prefix = new long[array.Length + 1];

            for (var i = 1; i <= array.Length; i++)
            {
                if(array[i - 1] == 0) positions.Add(i-1);
                prefix[i] = prefix[i - 1] + array[i - 1];
            }

            return prefix;
        }
    }
}
