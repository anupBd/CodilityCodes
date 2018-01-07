using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityCS
{
    class Solution
    {
        public int solution(int N)
        {
            var chars = Convert.ToString(N, 2).ToCharArray();
            bool start = false;
            int maxCount = 0;
            int count = 0;

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == '1') start = true;
                if (chars[i] == '1' && count > 0)
                {
                    if (count > maxCount) maxCount = count;
                    count = 0;
                }
                if (start && chars[i] == '0') count++;
            }


            return maxCount;
        }
    }
}
