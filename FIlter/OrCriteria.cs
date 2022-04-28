using System.Collections.Generic;

namespace DesignPatterns.FIlter
{
    public class OrCriteria: ICriteria
    {

        private readonly ICriteria _criteria;
        private readonly ICriteria _otherCriteria;

        public OrCriteria(ICriteria criteria, ICriteria otherCriteria)
        {
            this._criteria = criteria;
            this._otherCriteria = otherCriteria;
        }

        public List<Person> MeetCriteria(List<Person> persons)
        {
            List<Person> firstCriteriaItems = _criteria.MeetCriteria(persons);
            List<Person> otherCriteriaItems = _otherCriteria.MeetCriteria(persons);

            foreach (Person person in otherCriteriaItems) {
                if (!firstCriteriaItems.Contains(person))
                {
                    firstCriteriaItems.Add(person);
                }
            }
            return firstCriteriaItems;
        }
    }
}