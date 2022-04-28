using System;

namespace DesignPatterns.Prototype
{
    public class Circle : Shape
    {
        public Circle()
        {
            Type = "Circle";
        }

        public override void Draw()
        {
            Console.WriteLine("Inside Circle::draw() method.");
        }
    }
}