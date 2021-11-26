using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HatDecoratorApp.Model;

namespace HatDecoratorApp.Model
{
    class GoldenHat : IHatDecorator
    {
        private IHat _hat;
        private String _name = "Golden";
        private double _price = 1500;
        private string _description = "Golden added cos of 1500";
        public GoldenHat(IHat hat)
        {
            this._hat = hat;
        }
        public string GetDescription()
        {
            return _description;
        }

        public string GetName()
        {
            return _hat.GetName()+" "+this._name;
        }

        public double GetPrice()
        {
            return _hat.GetPrice() + _price;
        }
    }
}
