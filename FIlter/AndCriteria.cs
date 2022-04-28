using System.Collections.Generic;

namespace DesignPatterns.FIlter
{
    public class AndCriteria: ICriteria
    {

        private readonly ICriteria _criteria;
        private readonly ICriteria _otherCriteria;

        public AndCriteria(ICriteria criteria, ICriteria otherCriteria)
        {
            this._criteria = criteria;
            this._otherCriteria = otherCriteria;
        }

        public List<Person> MeetCriteria(List<Person> persons)
        {
            List<Person> firstCriteriaPersons = _criteria.MeetCriteria(persons);
            return _otherCriteria.MeetCriteria(firstCriteriaPersons);
        }
    }
}