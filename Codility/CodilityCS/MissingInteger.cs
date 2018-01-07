using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityCS
{
    class MissingInteger
    {
        public int solution(int[] A)
        {
            Array.Sort(A);
            int min = 1;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > min) break;
                if (min == A[i]) min++;
            }
            return min;
        }
    }
}
