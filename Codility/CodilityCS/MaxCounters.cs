using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityCS
{
    class MaxCounters
    {
        public int[] solution(int N, int[] A)
        {
            var result = new int[N];

            int maxval = 0;
            for (var i = 0; i < A.Length; i++)
            {
                var operation = A[i];
                if (operation >= 1 && operation <= N)
                {
                    result[operation-1]++;
                    if (result[operation - 1] > maxval) maxval = result[operation - 1];
                }
                else if (operation == N + 1)
                {
                    SetMax(result, maxval);
                }
            }

            return result;
        }

        public void SetMax(int[] array, int max)
        {
            for (var i = 0; i < array.Length/2; i++)
            {
                array[i] = max;
            }
        }
    }
}
