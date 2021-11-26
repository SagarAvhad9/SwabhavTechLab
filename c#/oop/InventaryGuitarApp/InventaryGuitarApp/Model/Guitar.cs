using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventaryGuitarApp.Model.Enum;

namespace InventaryGuitarApp.Model
{
    class Guitar
    {
        private string _serialNumber;
        private double _price;
        private Builder _builder;
        private string _model;
        private GuitarType _type;
        private Wood _backWood;
        private Wood _topWood;
        public Guitar( string serialNumber,double price, Builder builder,string model, GuitarType type,Wood backWood,Wood topWood)
        {
            _serialNumber = serialNumber;
            _price = price;
            _builder = builder;
            _model = model;
            _type = type;
            _backWood = backWood;
            _topWood = topWood;
        }
        public string SerialNumber
        {
            get
            {
                return _serialNumber;
            }
        }
        public double Price
        {
            get
            {
                return _price;
            }
        }
        public Builder Builder
        {
            get
            {
                return _builder;
            }
        }
        public string Model
        {
            get
            {
                return _model;
            }
        }
        public GuitarType Type
        {
            get
            {
                return _type;
            }
        }
        public Wood BackWood
        {
            get
            {
                return _backWood;
            }
        }
        public Wood TopWood
        {
            get
            {
                return _topWood;
            }
        }
    }
}
