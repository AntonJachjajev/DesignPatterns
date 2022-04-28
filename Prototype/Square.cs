using System;

namespace DesignPatterns.Prototype
{
    public class Square : Shape
    {
        public Square()
        {
            Type = "Square";
        }

        public override void Draw()
        {
            Console.WriteLine("Inside Square::draw() method.");
        }
    }
}