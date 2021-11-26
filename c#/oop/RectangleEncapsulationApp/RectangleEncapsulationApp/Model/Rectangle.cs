using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleEncapsulationApp.Model
{
    class Rectangle
    {
        private int width;
        private int height;
        private int Lower_Bound = 1;
        private int Upper_Bound = 100;


        public void SetHeight(int pheight)
        {
            height = pheight;
        }
        public int GetHeight()
        {
            height = Valid(height);
            return height;
        }
        public void SetWidth(int pWidth)
        {
            width= pWidth;
        }
        public int GetWidth()
        {
            width = Valid(width);
            return width;
        }
        public int Valid(int value)
        {
            if(value < Lower_Bound)
            {
                Console.WriteLine("lower bound is set to 1", value);
                return Lower_Bound;
            }
            else if (value > Upper_Bound)
            {
                Console.WriteLine("upper bound is set to 100", value);
                return Upper_Bound;
            }
            else
            {
                return value;
            }
            
        }
        public int CalculateArea(int pHeight,int pWidth)
        {
            int height = Valid(pHeight);
            int width = Valid(pWidth);

            return width * height;
        }


    }
}
