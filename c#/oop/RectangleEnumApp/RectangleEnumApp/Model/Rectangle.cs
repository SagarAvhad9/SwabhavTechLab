using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleEnumApp.Model
{
    class Rectangle
    {
        private int _width;
        private int _height;
        private ColorType _borderColor;

        public enum ColorType
        {
            Red, Green, Blue
        }
        public Rectangle()
        {
            _borderColor = ColorType.Red;
        }

        public int Width
        {
            set
            {
                if(value<1)
                {
                    _width = 1;
                }
                else if (value > 100)
                {
                    _width = 100;
                }
                else
                {
                    _width = value;
                }


            }
            get
            {
                return _width;
            }
        }
        public int Height
        {
            set
            {
                if(value<1)
                {
                    _height = 1;
                }
                else if(value>100)
                {
                    _height = 100;
                }
                else
                {
                    _height = value;
                }

            }
            get
            {
                return _height;
            }
        }
        public ColorType BorderColor
        {
            set
            {
                _borderColor = value;
            }
            get
            {
                return _borderColor;
            }
        }
        public int CalculateArea()
        {
            return _width*_height;
        }
    }
}
