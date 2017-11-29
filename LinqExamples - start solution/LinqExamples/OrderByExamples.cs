using System;
using System.Collections.Generic;
using System.Linq;
using LinqExamples.Models;

namespace LinqExamples
{
    public class OrderByExamples
    {
        public int[] SortNumbersDescending(int[] numbers)
        {
            List<int> descNumbersList = new List<int>();

            //Use the "ToArray" extension method to convert an IEnumerable to an Array
            int[] nummers = numbers.ToArray();

            //Define the query expression
            var descendingNumbersQuery = from nummer in nummers
                                         orderby nummer descending
                                         select nummer;

            //Execute the query
            foreach (var nummer in descendingNumbersQuery)
            {
                descNumbersList.Add(nummer);
            }

            int[] descNumbers = descNumbersList.ToArray();

            return descNumbers;

        }

        public IList<Person> SortPersonsOnDescendingAgeAndThenOnDescendingName(List<Person> persons)
        {

            List<Person> personsList = new List<Person>();
            List<Person> descendingPersonsList = new List<Person>();

            //Use the "ToList" extension method to convert an IEnumerable to a List
            personsList = persons.ToList();

            //Define the query expression
            var descendingPersonsQuery = from person in personsList
                                         orderby person.Age descending, person.Name descending
                                         select person;

            //Execute the query
            foreach (var person in descendingPersonsQuery)
            {
                descendingPersonsList.Add(person);
            }

            return descendingPersonsList;
        }
    }
}