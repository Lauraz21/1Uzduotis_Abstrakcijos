using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace _1Uzduotis_Abstrakcijos
{
    internal class Square : GeometricShape
    {
        public double SideA {  get; set; }
      
        public Square (double sideA)
        {
            SideA = sideA;  
        }

        public override double GetArea()
        {
            return SideA * SideA;  
        }

        public override double GetPerimeter()
        {
            return SideA * 4; 
        }
    }
}
