using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityCS
{
    class FrogJmp
    {
        public int solution(int X, int Y, int D)
        {
            return (int) Math.Ceiling((decimal)(Y - X) / D);

        }
    }
}
