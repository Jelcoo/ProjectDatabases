using SomerenDAL;
using System;
using System.Collections.Generic;

namespace SomerenService
{
    public class VATService
    {
        private OrderDao orderDao;

        public VATService()
        {
            orderDao = new OrderDao();
        }

        public List<Dictionary<string, object>> GetVatSummary(DateTime startDate, DateTime endDate)
        {
            return orderDao.GetVatSummary(startDate, endDate);
        }

        public decimal GetTotalTaxNeeded(DateTime startDate, DateTime endDate)
        {
            return orderDao.GetTotalTaxNeeded(startDate, endDate);
        }
    }
}
