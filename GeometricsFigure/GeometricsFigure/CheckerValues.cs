using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricsFigure
{
    public static class CheckerValues
    {
        public static double CheckValue(double value)
        {
            if ( value <= 0 )
            {
                throw new ArgumentException("Значение не может быть нулевым или меньше нуля");
            }
            return value;
        }
    }
}
