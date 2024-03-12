using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenUI
{
    public class Helpers
    {
        public (DateTime startDate, DateTime endDate) GetQuarterDates(int year, string quarter)
        {
            int monthStart = (quarter == "Q1" ? 1 : quarter == "Q2" ? 4 : quarter == "Q3" ? 7 : 10);
            DateTime startDate = new DateTime(year, monthStart, 1);
            DateTime endDate = startDate.AddMonths(3).AddDays(-1);
            return (startDate, endDate);
        }
    }
}
