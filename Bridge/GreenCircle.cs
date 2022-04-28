using System;

namespace DesignPatterns.Bridge
{
    public class GreenCircle : DrawAPI
    {

        public void DrawCircle(int radius, int x, int y)
        {
            Console.WriteLine("Drawing Circle[ color: green, radius: " + radius + ", x: " + x + ", " + y + "]");
        }
    }
}