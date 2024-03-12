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
            int red = Math.Abs(hash % 256);
            int green = Math.Abs((hash / 256) % 256);
            int blue = Math.Abs((hash / (256 * 256)) % 256);

            // Ensure the RGB values are above the minimum threshold
            red = Math.Max(red, 100);
            green = Math.Max(green, 100);
            blue = Math.Max(blue, 100);

            // Create and return the Color object
            return Color.FromArgb(red, green, blue);
        }

    }
}
