using System.Collections.Generic;

namespace Billing
{
    public class Store
    {

        IList<Item> _inventory = null;

        public IList<Item> inventory
        {
            get
            {
                if (_inventory == null)
                {
                    _inventory = createInventory();
                }
                return _inventory;
            }
        }

        public IList<Item> createInventory()
        {
            var items = new List<Item>();
            items.Add(new Item(1, "Cola", 0.50, "Cold", true));
            items.Add(new Item(2, "Coffee", 1.00, "Hot", true));
            items.Add(new Item(3, "Cheese", 2.00, "Cold", false));
            items.Add(new Item(4, "Steak", 4.50, "Hot", false));
            return items;

        }

        public Item getItem(int id)
        {
            return (inventory as List<Item>).Find(i => i.id == id);
        }
    }
}
