using SomerenDAL;
using SomerenModel;

namespace SomerenService
{
    public class OrderService
    {
        private OrderDao orderdb;
        private ProductDao productdb;

        public OrderService()
        {
            orderdb = new OrderDao();
            productdb = new ProductDao();
        }

        public void StoreOrder(Order order)
        {
            int orderId = orderdb.StoreOrder(order);
            foreach (OrderLine orderLine in order.OrderLines)
            {
                orderdb.StoreOrderLine(orderId, orderLine);
                productdb.DecreaseStock(orderLine);
            }
        }
    }
}
