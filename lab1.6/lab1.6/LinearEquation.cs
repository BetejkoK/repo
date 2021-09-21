using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1._6
{
    public class LinearEquation
    {
        private double a;
        private double b;
        private double c;
        public double F() 
        {
            if (A != 0)
                return (C - B) / A;
            else return double.NaN;
        }
        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }
        public double C { get => c; set => c = value; }
    }
}
