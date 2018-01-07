using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityCS
{
    class TapeEquilibrium
    {
        public int solution(int[] A)
        {
            long left = A[0];
            long right = 0;
            long i = 1;
            while (i < A.Length)
            {
                right += A[i];
                i++;
            }
            int diff = (int) Math.Abs(left - right);
            for (int j = 1; j < A.Length-1; j++)
            {
                left += A[j];
                right -= A[j];
                if (Math.Abs(left - right) < diff) diff = (int)Math.Abs(left - right);
            }

            return diff;
        }


    }
}
