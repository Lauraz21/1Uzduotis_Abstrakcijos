using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Uzduotis_Abstrakcijos
{
    internal class Triangle : GeometricShape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double sideA, double sideB, double sideC) 
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        
        }

        public override double GetArea()
        {
             return (SideA * SideB * SideC) / 2;
        }

        public override double GetPerimeter()
        {
            return SideA + SideB + SideC;
        }
    }
}
