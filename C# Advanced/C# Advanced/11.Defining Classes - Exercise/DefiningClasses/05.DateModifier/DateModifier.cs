using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class DateModifier
    {
        private DateTime firstDate;
        private DateTime secondDate;

        public double DifferentBetweenDays(string firstDay, string secondData)
        {
            firstDate = CreateData(firstDay);
            secondDate = CreateData(secondData);

            var different = Math.Abs((secondDate - firstDate).TotalDays);
            return different;
        }

        private DateTime CreateData(string dateString)
        {
            string[] firstDayParts = dateString.Split();
            int year = int.Parse(firstDayParts[0]);
            int month = int.Parse(firstDayParts[1]);
            int day = int.Parse(firstDayParts[2]);

            DateTime date = new DateTime(year, month, day);
            return date;
        }
    }
}
