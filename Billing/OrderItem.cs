namespace Billing
{
    public class OrderItem
    {
        public Item orderItem { get; set; }
        public int quantity { get; set; }

        internal double calcItemPrice()
        {
            return orderItem.price * quantity;
        }

        internal void increaseQuantity()
        {
            quantity += 1;
        }
    }
}
