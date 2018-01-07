using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityCS
{
    class MinAvgTwoSlice
    {
        public int solution(int[] A)
        {
            double minV = (A[0] + A[1]) / 2.0;
            int minP = 0;

            for (int i = 0; i < A.Length - 2; i++)
            {
                double tempMinV = min((A[i] + A[i + 1]) / 2.0, 
                    (A[i] + A[i + 1] + A[i + 2]) / 3.0);

                if (tempMinV < minV)
                {
                    minV = tempMinV;
                    minP = i;
                }
            }

            if (((A[A.Length - 2] + A[A.Length - 1]) / 2.0) < minV)
            {
                minP = A.Length - 2;
            }

            return minP;
        }

        double min(double a, double b)
        {
            return (a < b) ? a : b;
        }
    }
}
