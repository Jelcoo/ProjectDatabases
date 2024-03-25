using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SomerenModel;

namespace SomerenUI
{
    public class Helpers
    {
        public static DateTime[] GetQuarterDates(int? year = null, string quarter = null)
        {
            if (year == null) year = DateTime.Today.Year;

            if (quarter == null)
            {
                int currentQuarter = (int)Math.Ceiling(DateTime.Today.Month / 3.0);
                quarter = $"Q{currentQuarter}";
            }

            // Calculate the start and end dates based on the specified year and quarter
            int monthStart = quarter == "Q1" ? 1 : quarter == "Q2" ? 4 : quarter == "Q3" ? 7 : 10;
            DateTime startDate = new DateTime(year.Value, monthStart, 1);
            DateTime endDate = startDate.AddMonths(3).AddDays(-1);

            return new DateTime[] { startDate, endDate };
        }

        public static string GetVatType(double vatRate)
        {
            if (vatRate == Product.NORMAL_VAT_RATE)
                return "Laag";
            else if (vatRate == Product.ALCOHOL_VAT_RATE)
                return "Hoog";
            else
                return "Overig";
        }

        public static Label CopyAndCloneLabel(Label originalLabel, string newText, int counter, string tag = "clonedLabel")
        {
            if (counter == 0)
            {
                originalLabel.Text = newText;
                return null;
            } else
            {
                // Create a new Label and copy properties from the original label
                Label clonedLabel = originalLabel;

                // Place the cloned label below the lowest positioned element in the same column
                clonedLabel.Top = originalLabel.Top + originalLabel.Height + 30 * counter;

                clonedLabel.Text = newText;
                clonedLabel.Tag = tag;
                clonedLabel.Visible = true;
                clonedLabel.Width = 80;

                originalLabel.Parent.Controls.Add(clonedLabel);

                return clonedLabel;
            }
        }

        public static void RemoveControlsWithTag(string tag, Control parent)
        {
            var taggedControls = new List<Control>();
            foreach (Control control in parent.Controls)
            {
                if (control.Tag?.ToString() == tag) taggedControls.Add(control);

                // Recursively call this method in case this is a container
                if (control.HasChildren) RemoveControlsWithTag(tag, control);
            }

            foreach (Control control in taggedControls) parent.Controls.Remove(control);
        }

        public static string StockToMessage(int stock)
        {
            if (stock <= 0)
                return "stock empty";
            else if (stock <= 10)
                return "nearly depleted";
            else
                return "stock sufficient";
        }
    }
}
