using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Uzduotis_Abstrakcijos
{
    public class Circle : GeometricShape
    {
        double Radius { get; set; }
        public Circle(double radius) 
        { 
            Radius = radius;
        }

        public override double GetArea()
        {
            return Radius * 3.14;
        }

        public override double GetPerimeter()
        {
            return Radius * 2;
        }
    }
}
