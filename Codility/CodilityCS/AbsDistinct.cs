using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityCS
{
    class AbsDistinct
    {
        public int solution(int[] A)
        {
            List<int> exists = new List<int>();
            int distinct = 0;
            for (var i = 0; i < A.Length; i++)
            {
                if (!exists.Contains(Math.Abs(A[i])))
                {
                    exists.Add(Math.Abs(A[i]));
                    distinct++;
                }
            }

            return distinct;
        }
    }
}
