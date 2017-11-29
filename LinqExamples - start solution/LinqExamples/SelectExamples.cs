using System;
using System.Collections.Generic;
using System.Linq;
using LinqExamples.Models;

namespace LinqExamples
{
    public class SelectExamples
    {
        public IList<double> RoundDoublesUsingProjection(IEnumerable<double> doubles)
        {
            List<double> doubleList = new List<double>();
            List<double> roundedList = new List<double>();

            //Use the "ToList" extension method to convert an IEnumerable to a List
            doubleList = doubles.ToList();

            //Define the query expression
            var roundedDoublesQuery = from number in doubleList
                                      select number;

            //Execute the query
            foreach (var number in roundedDoublesQuery) //triggers query execution
            {
                //Round decimal to the nearest whole number
                Math.Round(number);
                roundedList.Add(number);
            }

            return roundedList;
        }

        public IList<AngleInfo> ConvertAnglesToAngleInfos(IEnumerable<double> anglesInDegrees)
        {
            List<double> anglesList = new List<double>();
            List<AngleInfo> angleInfosList = new List<AngleInfo>();

            //Use the "ToList" extension method to convert an IEnumerable to a List
            anglesList = anglesInDegrees.ToList();

            //Define the query expression
            var convertedAnglesQuery = from angle in anglesList
                                       select angle;

            //Execute the query
            foreach (var angle in convertedAnglesQuery) //triggers query execution
            {
                AngleInfo hoek = new AngleInfo();
                hoek.Angle = angle;
                hoek.Cosinus = Math.Cos(angle * Math.PI / 180);
                hoek.Sinus = Math.Sin(angle * Math.PI / 180);
                angleInfosList.Add(hoek);
            }

            return angleInfosList;
        }
    }
}
