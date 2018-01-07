using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityCS
{
    class PermCheck
    {
        public int solution(int[] A)
        {
            Array.Sort(A);
            for (int i = 1; i <= A.Length; i++)
            {
                if (i != A[i-1]) return 0;
            }
            return 1;
        }
    }
}
