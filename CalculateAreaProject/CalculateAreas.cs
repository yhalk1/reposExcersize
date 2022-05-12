using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateMethods
{
    public class CalculateAreas
    {
        public double TriangleArea(double a, double b)
        {
            return Math.Round((0.5 * a * b),2);
        }

        public double SquareArea(double a)
        {
            return Math.Round(Math.Pow(a, 2), 2);
        }

        public double RectangleArea(double a, double b)
        {
            return Math.Round((a * b), 2);
        }
    }
}
