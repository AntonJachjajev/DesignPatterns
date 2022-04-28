using DesignPatterns.Adaptor;
using DesignPatterns.Bridge;
using DesignPatterns.Builder;
using DesignPatterns.FIlter;
using DesignPatterns.Prototype;
using System;
using System.Collections.Generic;
using DesignPatterns.Composite;

namespace DesignPatterns
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //ShowSingletonPatter();
            //BuilderPatternDemo();
            //PrototypePatternDemo();
            //AdapterPatternDemo();
            //BridgePatternDemo();
            //CriteriaPatternDemo();
            CompositePatternDemo();
        }

        private static void CompositePatternDemo()
        {
            Employee CEO = new Employee("John", "CEO", 30000);

            Employee headSales = new Employee("Robert", "Head Sales", 20000);

            Employee headMarketing = new Employee("Michel", "Head Marketing", 20000);

            Employee clerk1 = new Employee("Laura", "Marketing", 10000);
            Employee clerk2 = new Employee("Bob", "Marketing", 10000);

            Employee salesExecutive1 = new Employee("Richard", "Sales", 10000);
            Employee salesExecutive2 = new Employee("Rob", "Sales", 10000);

            CEO.Add(headSales);
            CEO.Add(headMarketing);

            headSales.Add(salesExecutive1);
            headSales.Add(salesExecutive2);

            headMarketing.Add(clerk1);
            headMarketing.Add(clerk2);

            //print all employees of the organization
            Console.WriteLine(CEO.ToString());

            CEO.GetSubordinates().ForEach(x=>
            {
                Console.WriteLine(x.ToString());
                x.GetSubordinates().ForEach(y => Console.WriteLine(y.ToString()));
            });
        }

        private static void CriteriaPatternDemo()
        {
            List<Person> persons = new()
            {
                new Person("Robert", "Male", "Single"),
                new Person("John", "Male", "Married"),
                new Person("Laura", "Female", "Married"),
                new Person("Diana", "Female", "Single"),
                new Person("Mike", "Male", "Single"),
                new Person("Bobby", "Male", "Single")
            };
            
            ICriteria male = new CriteriaMale();
            ICriteria female = new CriteriaFemale();
            ICriteria single = new CriteriaSingle();
            ICriteria singleMale = new AndCriteria(single, male);
            ICriteria singleOrFemale = new OrCriteria(single, female);

            Console.WriteLine("Males: ");
            PrintPersons(male.MeetCriteria(persons));

            Console.WriteLine("\nFemales: ");
            PrintPersons(female.MeetCriteria(persons));

            Console.WriteLine("\nSingle Males: ");
            PrintPersons(singleMale.MeetCriteria(persons));

            Console.WriteLine("\nSingle Or Females: ");
            PrintPersons(singleOrFemale.MeetCriteria(persons));
        }

        private static void PrintPersons(List<Person> persons)
        {

            persons.ForEach(x=> Console.WriteLine("Person : [ Name : " + x.GetName() + ", Gender : " + x.GetGender() + ", Marital Status : " + x.GetMaritalStatus() + " ]"));
        }

        private static void BridgePatternDemo()
        {
            Bridge.Shape redCircle = new Bridge.Circle(100, 100, 10, new RedCircle());
            Bridge.Shape greenCircle = new Bridge.Circle(100, 100, 10, new GreenCircle());

            redCircle.Draw();
            greenCircle.Draw();
        }

        private static void AdapterPatternDemo()
        {
            var audioPlayer = new AudioPlayer();

            audioPlayer.Play("mp3", "beyond the horizon.mp3");
            audioPlayer.Play("mp4", "alone.mp4");
            audioPlayer.Play("vlc", "far far away.vlc");
            audioPlayer.Play("avi", "mind me.avi");
        }

        private static void PrototypePatternDemo()
        {
            ShapeCache.LoadCache();

            var clonedShape = ShapeCache.GetShape("1");
            Console.WriteLine("Shape : " + clonedShape.GetType());

            var clonedShape2 = ShapeCache.GetShape("2");
            Console.WriteLine("Shape : " + clonedShape2.GetType());

            var clonedShape3 = ShapeCache.GetShape("3");
            Console.WriteLine("Shape : " + clonedShape3.GetType());
        }

        private static void BuilderPatternDemo()
        {
            var mealBuilder = new MealBuilder();

            var vegMeal = mealBuilder.PrepareVegMeal();
            Console.WriteLine("Veg Meal");
            vegMeal.showItems();
            Console.WriteLine("Total Cost: " + vegMeal.GetCost());

            var nonVegMeal = mealBuilder.PrepareNonVegMeal();
            Console.WriteLine("\n\nNon-Veg Meal");
            nonVegMeal.showItems();
            Console.WriteLine("Total Cost: " + nonVegMeal.GetCost());
        }

        private static void ShowSingletonPatter()
        {
            //Get the only object available
            var singleton = Singleton.Singleton.GetInstance();

            //show the message
            singleton.ShowMessage();
        }
    }
}
