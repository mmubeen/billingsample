namespace Billing
{
    public class Pos
    {
        Order myOrder = new Order();
        Store store = new Store();
        Printer printer = new Printer();
        public void reset()
        {
            myOrder = new Order();
        }

        public void orderItem(int id)
        {
            var existsItem = myOrder.findItem(id);
            if (existsItem == null)
            {
                var selectItem = store.getItem(id);
                if (selectItem != null)
                    myOrder.OrderItems.Add(new OrderItem() { orderItem = selectItem, quantity = 1 });
            }

            else
                existsItem.increaseQuantity();
        }

        public string displayBill()
        {
            return printer.printOrder(myOrder);
        }


    }
}
