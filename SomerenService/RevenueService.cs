using SomerenDAL;
using SomerenModel;
using System;

namespace SomerenService
{
    public class RevenueService
    {
        private RevenueDao revenuedb;

        public RevenueService()
        {
            revenuedb = new RevenueDao();
        }

        public Revenue GetRevenue(DateTime start, DateTime end)
        {
            Revenue revenue = revenuedb.GetRevenue(start, end);
            return revenue;
        }
    }
}
