using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_OOP04
{
    internal class Circle : IShape
    {
        public double Area { get ;
            set ; }
     
        public void DisplayShapeInfo()
        {
            Console.WriteLine(Area);
        }
        public override string ToString()
        {
            return $"{Area}";
        }

    }
}
