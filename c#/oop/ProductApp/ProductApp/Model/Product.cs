using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Model
{
    class Product
    {
        private int _id;
        private string _name;
        private double _price;
        private float _discountPercent;
        private static int _count = 0;
        
        
        public Product(int id,string name,double price,float discountPercent)
        {
            _id = id;
            _name = name;
            _price = price;
            _discountPercent = discountPercent;
            _count += 1;
            Console.WriteLine("constructor 1");
        }
        public Product(int id, string name,double price)
        {
            _id = id;
            _name = name;
            _price = price;
            _discountPercent = 0.2f;
            _count += 1;
            Console.WriteLine("constructor 2");
        }
        public static int Occurances
        {
            get
            {
                return _count;
            }
        }
        static Product()
        {
            _count = 0;
            Console.WriteLine("Static constructor");
        }

        public int ID
        {
            get
            {
                return _id;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public double Price
        {
            get
            {
                return _price;
            }
        }
        public float DiscountPercent
        {
            get
            {
                return _discountPercent;
            }
        }
        public int Count
        {
            get
            {
                return _count;
            }
        }
        public double Discount
        {
           
            get
            {
                return _price-=(_price*_discountPercent)/100;
            }
        }

    }
}
