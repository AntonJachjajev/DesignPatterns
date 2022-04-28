using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public class Singleton
    {

        //create an object of Singleton
        private static readonly Singleton Instance = new();

        //make the constructor private so that this class cannot be
        //instantiated
        private Singleton() { }

        //Get the only object available
        public static Singleton GetInstance()
        {
            return Instance;
        }

        public void ShowMessage()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
