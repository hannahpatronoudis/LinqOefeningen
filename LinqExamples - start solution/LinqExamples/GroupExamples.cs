using System;
using System.Collections.Generic;
using System.Linq;
using LinqExamples.Models;

namespace LinqExamples
{
    public class GroupExamples
    {
        public IList<IGrouping<int, int>> GroupEvenAndOddNumbers(int[] numbers)
        {
            List<int> nummersList = new List<int>();

            //Use the "ToList" extension method to convert an IEnumerable to a List
            nummersList = numbers.ToList();

            //Define the query expression
            var groupedNumbersQuery = from nummer in nummersList
                                        group nummer by nummer % 2 == 0 into evenNumberGroup
                                        select new
                                        {

                                        };

            //Er wordt een lijst in een lijst terug gegeven
            //1 lijst met even nummers, 1 lijst met oneven nummers
            //met daarin alle nummers

            //Execute the query

            throw new NotImplementedException();
           
        }

        public IList<PersonAgeGroup> GroupPersonsByAge(List<Person> persons)
        {
            List<Person> personsList = new List<Person>();
            List<Person> groupedPersonsList = new List<Person>();

            //Use the "ToList" extension method to convert an IEnumerable to a List
            personsList = persons.ToList();

            //Define the query expression
            var groupedPersonsQuery = from person in personsList
                                      group person by person.Age into personAgeGroup
                                      select new
                                      {
                                          Age = personAgeGroup.Key
                                      };

            //Execute the query
            foreach (var person in groupedPersonsQuery)
            {
              //  groupedPersonsList.Add(person);
            }

            //return groupedPersonsList;

            throw new NotImplementedException();

        }
    }
}