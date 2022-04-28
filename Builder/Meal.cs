using System;
using System.Collections.Generic;

namespace DesignPatterns.Builder
{
    public class Meal
    {
        private List<IItem> items = new List<IItem>();

        public void AddItem(IItem item)
        {
            items.Add(item);
        }

        public float GetCost()
        {
            float cost = 0.0f;

            foreach (IItem item in items)
            {
                cost += item.Price();
            }
            return cost;
        }

        public void showItems()
        {
            foreach (IItem item in items)
            {
                Console.Write("Item : " + item.Name());
                Console.Write(", Packing : " + item.Packing().Pack());
                Console.WriteLine(", Price : " + item.Price());
            }
        }
    }
}