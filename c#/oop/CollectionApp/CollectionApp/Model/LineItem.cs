using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionApp.Model
{
    class LineItem
    {
        private string _productName;
        private double _price;
        private int _quantity;
        public LineItem(string productName,double price,int quantity )
        {
            _productName = productName;
            _price = price;
            _quantity = quantity;
        }
        public string ProductName
        {
            set
            {

            }
            get
            {
                return _productName;
            }
        }
        public double Price
        {
            set
            {

            }
            get
            {
                return _price;
            }
        }
        public int Quantity
        {
            set
            {

            }
            get
            {
                return _quantity;
            }
        }
        public double TotalPrice()
        {
            double totalPrice = _price * _quantity;
            return totalPrice;
        }
    }
}
