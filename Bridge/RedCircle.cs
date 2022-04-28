﻿using System;

namespace DesignPatterns.Bridge
{
    public class RedCircle : DrawAPI
    {

        public void DrawCircle(int radius, int x, int y)
        {
            Console.WriteLine("Drawing Circle[ color: red, radius: " + radius + ", x: " + x + ", " + y + "]");
        }
    }
}
