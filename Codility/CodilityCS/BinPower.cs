using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityCS
{
    class BinPower
    {
        public int solution(int[] array)
        {
            List<int> x = new List<int>();

            var next = findBin(array);

            while (next > 0)
            {
                var p = nextPowTailRec(next);
                next = next - p;
                x.Add((int)Math.Log(p, 2));
            }

            return x.Count;
        }

        public long findBin(int[] array)
        {
            long bin = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bin += (long) Math.Pow(2, array[i]);
            }
            return bin;
        }

        public long nextPowTailRec(long x)
        {
            return x <= 2 ? x : nextPowTailRec(x >> 1) << 1;
        }
    }
}
