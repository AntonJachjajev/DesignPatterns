using System;
using System.Collections.Generic;

namespace DesignPatterns.Prototype
{
    public class ShapeCache
    {
        private static Dictionary<string, Shape> shapeMap = new Dictionary<String, Shape>();

        public static Shape GetShape(String shapeId)
        {
            shapeMap.TryGetValue(shapeId, out var cachedShape);
            return (Shape)cachedShape?.Clone();
        }

        // for each shape run database query and create shape
        // shapeMap.put(shapeKey, shape);
        // for example, we are adding three shapes

        public static void LoadCache()
        {
            Circle circle = new Circle();
            circle.SetId("1");
            shapeMap.Add(circle.GetId(), circle);

            Square square = new Square();
            square.SetId("2");
            shapeMap.Add(square.GetId(), square);

            Rectangle rectangle = new Rectangle();
            rectangle.SetId("3");
            shapeMap.Add(rectangle.GetId(), rectangle);
        }
    }
}