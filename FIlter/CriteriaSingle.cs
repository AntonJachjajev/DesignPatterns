using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.FIlter
{
    public class CriteriaSingle: ICriteria
    {
        public List<Person> MeetCriteria(List<Person> persons)
        {
            return persons.Where(person => person.GetMaritalStatus().Equals("SINGLE", StringComparison.InvariantCultureIgnoreCase)).ToList();
        }
    }
}