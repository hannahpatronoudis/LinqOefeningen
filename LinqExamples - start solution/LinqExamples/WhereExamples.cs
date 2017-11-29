using System;
using System.Collections.Generic;
using System.Linq;
using LinqExamples.Models;

namespace LinqExamples
{
    public class WhereExamples
    {
        public int[] FilterOutNumbersDivisibleByFive(int[] numbers)
        {
            List<int> divFiveList = new List<int>();

            //Use the "ToArray" extension method to convert an IEnumerable to an Array
            int[] nummers = numbers.ToArray();

            //Define the query
            var filterFiveQuery = from nummer in nummers
                                  where nummer % 5 == 0
                                  select nummer;

            //Execute the query
            foreach (var number in filterFiveQuery) //triggers query execution
            {
                divFiveList.Add(number);
            }

            int[] divFive = divFiveList.ToArray();

            return divFive;
        }

        public IList<Person> FilterOutPersonsThatAreEighteenOrOlder(List<Person> persons)
        {

            List<Person> personenList = new List<Person>();
            List<Person> filteredList = new List<Person>();

            //Use the "ToList" extension method to convert an IEnumerable to a List
            personenList = persons.ToList();

            //Define the query
            var eighteenOrOlderQuery = from person in personenList
                                       where person.Age >= 18
                                       select person;

            //Execute the query
            foreach (var person in eighteenOrOlderQuery)
            {
                filteredList.Add(person);
            }

            return filteredList;
        }
    }
}