using System;
using Movement;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of Car
        Car car = new Car();
        car.Move();  

        // Create an instance of Bicycle
        Bicycle bicycle = new Bicycle();
        bicycle.Move();  
    }
}
