using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shapes
{
    class Circle : Shape{
        public double Radius { get; set; }

        public Circle(double radius){
        Radius = radius;
        }

        public override double GetArea(){
        return Math.PI * Radius * Radius;
        }
    }

    
}