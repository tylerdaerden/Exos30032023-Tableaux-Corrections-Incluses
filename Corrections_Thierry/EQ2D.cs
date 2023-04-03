using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F23L034_Methods
{
    internal struct EQ2D
    {
        public int A, B, C;

        public bool Resoudre(out double? x1, out double? x2)
        {
            x1 = x2 = null;

            if(A == 0)
            {
                return false;
            }

            double delta = Math.Pow(B, 2) - (4 * A * C);

            if(delta >= 0)
            {
                x1 = (-B - Math.Sqrt(delta)) / (2 * A);
                x2 = (-B + Math.Sqrt(delta)) / (2 * A);
                return true;
            }

            return false;
        }
    }
}
