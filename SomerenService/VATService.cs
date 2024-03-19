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

        public List<Dictionary<string, object>> GetVatSummary(DateTime[] dateRanges)
        {
            if (dateRanges.Length > 2 || dateRanges.Length == 0)
                return null;
            return orderDao.GetVatSummary(dateRanges[0], dateRanges[1]);
        }

        public double GetTotalTaxNeeded(DateTime[] dateRanges)
        {
            if(dateRanges.Length > 2 || dateRanges.Length == 0)
                return 0;
            return orderDao.GetTotalTaxNeeded(dateRanges[0], dateRanges[1]);
        }
    }
}
