using System;
using System.Collections.Generic;
using System.Linq;
using LinqExamples.Models;

namespace LinqExamples
{
    public class JoinExamples
    {
        public int[] GetIntersection(int[] firstList, int[] secondList)
        {

            List<int> intersectionList = new List<int>();
            int[] intersectionArray = null;

            //Use the "ToArray" extension method to convert an IEnumerable to an Array
            int[] arrayOne = firstList.ToArray();
            int[] arrayTwo = firstList.ToArray();

            //Define the query expression
            /*var intersectionQuery = from nummerEen in arrayOne
                                    join nummerTwee in arrayTwo on nummerEen.? equals nummerTwee.?
                                    select */

            //Execute the query

            return intersectionArray;

        }

        public IList<string> FindCouplesByAgeUsingJoin(List<Person> boys, List<Person> girls)
        {
            //Use the "ToList" extension method to convert an IEnumerable to a List
            List<Person> boysList = boys.ToList();
            List<Person> girlsList = girls.ToList();

            //Define the query expression
            var findCouplesQuery = from boy in boysList
                                   join girl in girlsList on boy.Age equals girl.Age
                                   select new
                                   {

                                   };

            throw new NotImplementedException();

        }
    }
}