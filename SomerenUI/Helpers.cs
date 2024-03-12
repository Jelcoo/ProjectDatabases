using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenUI
{
<<<<<<< HEAD
    public class Helpers
    {
        public (DateTime startDate, DateTime endDate) GetQuarterDates(int year, string quarter)
        {
            int monthStart = (quarter == "Q1" ? 1 : quarter == "Q2" ? 4 : quarter == "Q3" ? 7 : 10);
            DateTime startDate = new DateTime(year, monthStart, 1);
            DateTime endDate = startDate.AddMonths(3).AddDays(-1);
            return (startDate, endDate);
        }
=======
    public class UIHelpers
    {
        public static Color StringToColor(string input)
        {
            // Use the GetHashCode method to get a hash code for the string
            int hash = input.GetHashCode();

            // Convert the hash code to RGB values
            int red = Math.Abs(hash % 156);
            int green = Math.Abs((hash / 156) % 156);
            int blue = Math.Abs((hash / (156 * 156)) % 156);

            // Ensure the RGB values are above the minimum threshold
            red += 100;
            green += 100;
            blue += 100;

            // Create and return the Color object
            return Color.FromArgb(red, green, blue);
        }

>>>>>>> dev
    }
}
