using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movement
{
    class Bicycle : IMovable {
        public void Move() {
        Console.WriteLine("Bicycle is moving");
        }
        
    }
}