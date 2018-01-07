using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityCS
{
    class CountDiv
    {
        public int solution(int A, int B, int K)
        {
            if (K > B) return 0;
            if (K >= A && K <= B && B - A < K) return 1;

            if (A % K == 0) return (B - A) / K + 1;

            return (B - (A + (K - A % K))) / K + 1;   

        }
    }
}
