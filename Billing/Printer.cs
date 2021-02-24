using System.Collections.Generic;

namespace Billing
{
    public class Printer
    {
        public string printOrder(Order order)
        {
            System.Text.StringBuilder bill = new System.Text.StringBuilder();
            if (order.OrderItems.Count == 0)
            {
                bill.AppendLine("no items added to order");
            }
            else
            {
                bill.AppendLine($"Product Name.......Quantity......Price....Cost");

                (order.OrderItems as List<OrderItem>).ForEach(item =>
                {
                    bill.AppendLine($"{item.orderItem.name}.......{item.quantity}......{item.orderItem.price}....{item.calcItemPrice()}");
                });

                bill.AppendLine($"Service Charge...........{order.ServiceCharge}");
                bill.AppendLine($"Order Total..............{order.OrderTotal}");
            }


            return bill.ToString();
        }
    }
}
