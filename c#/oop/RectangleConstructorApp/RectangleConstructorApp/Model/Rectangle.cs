using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleConstructorApp.Model
{
    class Rectangle
    {
        private static int _height;
        private static int _width;
        private static string _color = "red";
        private static string _borderColor = "red";

        public Rectangle(int height, int width, string color)
        {
            _height = ValidationValue(height);
            _width = ValidationValue(width);
            _color = ValidationColor(color);
            
        }
        public Rectangle(int height,int width,string color,string bodycolor)
        {
            _height = ValidationValue(height);
            _width = ValidationValue(width);
            _color = ValidationColor(color);
            _borderColor = ValidationColor(bodycolor);
        }
        public int Area()
        {
            return _height * _width;
        }
        private int ValidationValue(int value)
        {
            int LowerBound = 1;int UpperBound = 100;

            if (value >= LowerBound && value <= UpperBound)
            {
                return value;
            }
            else if(value<LowerBound)
            {
                Console.WriteLine("out of bound value set to 1");
                return LowerBound;
            }
            else
            {
                Console.WriteLine("out of bound value set to 100");
                return UpperBound;
            } 
        }
        private string ValidationColor(string colors)
        {
            string DefaultColor = "red";
            if (colors.ToLower() == "red" || colors.ToLower() == "green" || colors.ToLower() == "blue")
            {
                return colors;
            }
            else
            {
                return DefaultColor;
            }
        }
        public int GetHeight()
        {
            return _height;
        }
        public int GetWidth()
        {
            return _width;
        }
        public string GetColor()
        {
            return _color;
        }
        public string GetBorderColor()
        {
            return _borderColor;
        }
    }
}
