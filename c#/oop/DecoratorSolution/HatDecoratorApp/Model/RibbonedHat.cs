using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatDecoratorApp.Model
{
    class RibbonedHat : IHatDecorator
    {
        private IHat _hat;
        private String _name = "Ribboned";
        private double _price = 1500;
        private string _description = "Ribboned added cost of 1500";
        public RibbonedHat(IHat hat)
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
