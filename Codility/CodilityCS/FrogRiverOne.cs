using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityCS
{
    class FrogRiverOne
    {
        public int solution(int X, int[] A)
        {
            Dictionary<int, bool> dic = new Dictionary<int, bool>();

            for (var i = 0; i < A.Length; i++)
            {
                dic[A[i]] = true;
                if (dic.Count == X) return i;
            }
            return -1;
        }
    }
}
