using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.FIlter
{
    public class CriteriaFemale: ICriteria
    {
        public List<Person> MeetCriteria(List<Person> persons)
        {
            return persons.Where(person => person.GetGender().Equals("FEMALE", StringComparison.InvariantCultureIgnoreCase)).ToList();
        }
    }
}