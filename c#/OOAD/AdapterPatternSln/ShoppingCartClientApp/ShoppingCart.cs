using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartClientApp
{
    public class ShoppingCart
    {
        public double _totalPrice;
        public List<Item> items = new List<Item>();
        public void Add(Item item)
        {
            items.Add(item);
        }
        public void Remove(Item item)
        {
            items.Remove(item);
        }
        public double TotalPrice()
        {
            foreach(Item item in items)
            {
                _totalPrice += item.ItemPrice();
            }
            return _totalPrice;
        }
    }
}
