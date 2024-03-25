using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SomerenUI
{
    public class Helpers
    {
        public static DateTime[] GetQuarterDates(int? year = null, string? quarter = null)
        {
            // Determine the current year and quarter if not specified
            if (year == null)
            {
                year = DateTime.Today.Year;
            }
            if (quarter == null)
            {
                int currentQuarter = (int)Math.Ceiling(DateTime.Today.Month / 3.0);
                quarter = $"Q{currentQuarter}";
            }

            // Calculate the start and end dates based on the specified year and quarter
            int monthStart = (quarter == "Q1" ? 1 : quarter == "Q2" ? 4 : quarter == "Q3" ? 7 : 10);
            DateTime startDate = new DateTime(year.Value, monthStart, 1);
            DateTime endDate = startDate.AddMonths(3).AddDays(-1);

            // Return the start and end dates as an array
            return new DateTime[] { startDate, endDate };
        }

        public static string GetVatType(double vatRate)
        {
            if (vatRate == 0.06)
                return "Laag";
            else if (vatRate == 0.21)
                return "Hoog";
            else
                return "Overig";
        }

        public static Label CopyAndCloneLabel(Label originalLabel, string newText, int counter, string? tag = "clonedLabel")
        {
            if (counter == 0)
            {
                originalLabel.Text = newText;
                return null;
            }
            else
            {
                // Create a new Label and copy properties from the original label
                Label clonedLabel = new Label();
                clonedLabel.Location = originalLabel.Location;


                // Place the cloned label below the lowest positioned element in the same column
                clonedLabel.Top = originalLabel.Top + originalLabel.Height + 30 * counter; // Adjust the spacing as needed

                clonedLabel.Margin = originalLabel.Margin;
                clonedLabel.Text = newText;
                clonedLabel.Font = originalLabel.Font;
                clonedLabel.Size = originalLabel.Size;
                clonedLabel.Padding = originalLabel.Padding;
                clonedLabel.Tag = tag;
                clonedLabel.Visible = true; // Ensure it's visible
                clonedLabel.Width = 60;

                // Add the cloned label to the form or a specific container
                originalLabel.Parent.Controls.Add(clonedLabel);

                // Add any other properties you want to copy

                return clonedLabel;
            }
        }

        public static void RemoveControlsWithTag(string tag, Control parent)
        {
            var taggedControls = new List<Control>();

            foreach (Control control in parent.Controls)
            {
                if (control.Tag?.ToString() == tag)
                {
                    taggedControls.Add(control);
                }

                // Recursively call this method in case this is a container
                if (control.HasChildren)
                {
                    RemoveControlsWithTag(tag, control);
                }
            }

            foreach (Control control in taggedControls)
            {
                parent.Controls.Remove(control);
            }
        }
    }
}
