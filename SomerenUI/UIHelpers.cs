using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenUI
{
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

    }
}
