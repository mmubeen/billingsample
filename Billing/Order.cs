using System.Collections.Generic;

namespace Billing
{
    public class Order
    {
        const double TIPRATE = 0.15;
        public IList<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public OrderItem findItem(int id)
        {
            return (OrderItems as List<OrderItem>).Find(i => i.orderItem.id == id);
        }

        public double ServiceCharge
        {
            get
            {
                return calcServiceCharge();
            }
        }

        public double OrderSubTotal
        {
            get
            {
                double total = 0;
                (OrderItems as List<OrderItem>).ForEach(i => total += i.calcItemPrice());
                return total;
            }
        }

        public double OrderTotal
        {
            get
            {
                return OrderSubTotal + calcServiceCharge();
            }
        }

        private double calcServiceCharge()
        {
            return isAllDrinks() ? 0 : OrderSubTotal * TIPRATE; ;
        }

        private bool isAllDrinks()
        {
            return (OrderItems as List<OrderItem>).TrueForAll(i => i.orderItem.isDrink);
        }
    }
}
