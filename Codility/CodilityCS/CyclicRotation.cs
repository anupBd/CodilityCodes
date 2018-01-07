using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityCS
{
    class CyclicRotation
    {
        public int[] solution(int[] A, int K)
        {
            var rotationNeeded = K % A.Length;
            if (rotationNeeded == 0) return A;
            List<int> list = new List<int>();

            for (int i = 0; i < A.Length; i++)
            {
                if (i < rotationNeeded) list.Add(A[A.Length - 1 - i]);
                if(i < A.Length - rotationNeeded)
                    A[A.Length - 1 - i] = A[A.Length - 1 - i - rotationNeeded];
            }
            for (int i = list.Count-1; i >= 0; i--)
            {
                A[i] = list[list.Count - 1 -i];
            }

            return A;
        }
    }
}
