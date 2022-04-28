using System.Collections.Generic;

namespace DesignPatterns.Composite
{
    public class Employee
    {
        private readonly string _name;
        private readonly string _dept;
        private readonly int _salary;
        private readonly List<Employee> _subordinates;

        // constructor
        public Employee(string name, string dept, int sal)
        {
            _name = name;
            _dept = dept;
            _salary = sal;
            _subordinates = new List<Employee>();
        }

        public void Add(Employee e)
        {
            _subordinates.Add(e);
        }

        public void Remove(Employee e)
        {
            _subordinates.Remove(e);
        }

        public List<Employee> GetSubordinates()
        {
            return _subordinates;
        }

        public new string ToString()
        {
            return ("Employee :[ Name : " + _name + ", dept : " + _dept + ", salary :" + _salary + " ]");
        }
    }
}
