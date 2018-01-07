using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityCS
{
    class OddOccurrencesInArray
    {
        public int solution(int[] A)
        {
            Dictionary<int, long> dic  = new Dictionary<int, long>();

            for (var i = 0; i < A.Length; i++)
            {
                if (dic.ContainsKey(A[i])) dic[A[i]]++;
                else
                {
                    dic[A[i]] = 1;
                }
            }
            return dic.SingleOrDefault(x => x.Value % 2 == 1).Key;
        }
    }
}
