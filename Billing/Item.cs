namespace Billing
{
    public class Item
    {
        public Item(int _id, string _name, double _price, string _type, bool _isDrink)
        {
            id = _id;
            name = _name;
            price = _price;
            type = _type;
            isDrink = _isDrink;

        }
        public int id { get; private set; }
        public string name { get; private set; }
        public double price { get; private set; }
        public string type { get; private set; }
        public bool isDrink { get; private set; }
    }
}
