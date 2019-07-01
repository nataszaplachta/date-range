using System;
using System.Linq;
using Xunit;

namespace DatesTests
{
    public class UnitTest1
    {
        [Fact]
        public void OnlyNumericValuesAreAccepted()
        {
            string date = "12.10.2013 M.10.2019";
            string[] split = date.Split('.', ' ');
            bool isNumeric = split.All(s => s.All(Char.IsDigit));
            Assert.False(isNumeric);
        }
        [Fact]
        public void DayMustBeCorrect()
        {
            string date = "12.10.2013 54.10.2019";

            string[] split = date.Split('.', ' ');
            bool isNumeric = split.All(s => s.All(Char.IsDigit));
            int firstDay = Convert.ToInt32(split[0]);
            int secondDay = Convert.ToInt32(split[3]);

            bool dayIsCorrect = firstDay > 1 && firstDay < 31 && secondDay > 1 && secondDay < 31;

            Assert.False(dayIsCorrect);
        }
        [Fact]
        public void MonthMustBeCorrect()
        {
            string date = "12.10.2013 21.14.2019";

            string[] split = date.Split('.', ' ');
            bool isNumeric = split.All(s => s.All(Char.IsDigit));

            int firstMonth = Convert.ToInt32(split[1]);
            int secondMonth = Convert.ToInt32(split[4]);

            bool monthIsCorrect = firstMonth > 1 && firstMonth < 12 && secondMonth > 1 && secondMonth < 12;

            Assert.False(monthIsCorrect);
        }
        [Fact]
        public void YearMustBeCorrect()
        {
            string date = "12.10.0000 21.10.2019";

            string[] split = date.Split('.', ' ');
            bool isNumeric = split.All(s => s.All(Char.IsDigit));

            int firstYear = Convert.ToInt32(split[2]);
            int secondYear = Convert.ToInt32(split[5]);

            bool yearIsCorrect = firstYear > 1 && firstYear < 9999 && secondYear > 1 && secondYear > 9999;

            Assert.False(yearIsCorrect);
        }
    }
}
