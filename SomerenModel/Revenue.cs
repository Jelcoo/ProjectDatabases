using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Revenue
    {
        public int TotalDrinksSold { get; }
        public int UniqueCustomers { get; }
        public double Turnover { get; }

        public Revenue(int totalDrinksSold, int uniqueCustomers, double turnover)
        {
            TotalDrinksSold = totalDrinksSold;
            UniqueCustomers = uniqueCustomers;
            Turnover = turnover;
        }
    }
}
