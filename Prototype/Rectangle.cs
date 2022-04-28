using System;

namespace DesignPatterns.Prototype
{
    public class Rectangle : Shape
    {
        public Rectangle()
        {
            Type = "Rectangle";
        }

        public override void Draw()
        {
            Console.WriteLine("Inside Rectangle::draw() method.");
        }
    }
}