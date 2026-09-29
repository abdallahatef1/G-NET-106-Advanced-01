using System;
using System.Collections.Generic;
using System.Text;

namespace advanced1
{
    internal class Circle :IShape
    {
        public double R;
        public Circle(double r) { R = r; }
        public double Area() { return Math.PI * R * R; }
    }
}
