using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FIlter
{
    public class Person
    {
        private readonly string _name;
        private readonly string _gender;
        private readonly string _maritalStatus;

        public Person(string name, string gender, string maritalStatus)
        {
            _name = name;
            _gender = gender;
            _maritalStatus = maritalStatus;
        }

        public string GetName()
        {
            return _name;
        }
        public string GetGender()
        {
            return _gender;
        }
        public string GetMaritalStatus()
        {
            return _maritalStatus;
        }
    }
}
