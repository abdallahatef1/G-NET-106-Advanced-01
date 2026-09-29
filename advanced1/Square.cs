using System;
using System.Collections.Generic;
using System.Text;

namespace advanced1
{
    internal class Square :IShape
    {
        public double S;
        public Square(double s) { S = s; }
        public double Area() { return S * S; }
    }
}
