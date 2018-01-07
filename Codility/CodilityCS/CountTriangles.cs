using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityCS
{
    class CountTriangles
    {

        public int solution(int[] A)
        {
            var possibleTriangle = 0;
            for (var i = 0; i < A.Length - 2; i++)
            {
                for (var j = i + 1; j < A.Length - 1; j++)
                {
                    for (var k = j + 1; k < A.Length; k++)
                    {
                        if (
                            A[i] + A[j] > A[k]
                            && A[i] + A[k] > A[j]
                            && A[j] + A[k] > A[i]
                        )
                        {
                            possibleTriangle++;
                        }
                    }
                }
            }

            return possibleTriangle;
        }
    }
}
