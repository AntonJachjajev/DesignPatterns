using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.FIlter
{
    public class CriteriaMale: ICriteria
    {
        public List<Person> MeetCriteria(List<Person> persons)
        {
            return persons.Where(person => person.GetGender().Equals("MALE", StringComparison.InvariantCultureIgnoreCase)).ToList();
        }
    }
}