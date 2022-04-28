using System.Collections.Generic;

namespace DesignPatterns.FIlter
{
    public interface ICriteria
    {
        public List<Person> MeetCriteria(List<Person> persons);
    }
}