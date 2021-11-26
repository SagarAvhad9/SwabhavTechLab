using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleEncapsulationApps.Model
{
    class Circle
    {
        private float _radius =0;
        private string _borderColor = "red";
        private String _fillCOlor = "red";
        private string Default_Color="red";
        private float Area;
        public float CalculateArea()
        {
            Area=( 3.14f* _radius * _radius);
            return Area;
        }
         private float ValidationRadius(float radius)
        {
            int LowerBound = 1;  int UpperBound = 10;
            if (LowerBound < radius && UpperBound > radius)
            {
                return radius;
            }
            else if (LowerBound < radius)
            {
                return LowerBound;
            }
            else
            {
                return UpperBound;
            }      
        }
        private string ValidationColor(string color)
        {
            if(color.ToLower() == "red" || color.ToLower() == "blue" || color.ToLower() == "green" ) 
            {
                return color;
            }
            return Default_Color;
        }
        public void SetRadius(float radius)
        {
            _radius = ValidationRadius(radius);
        }
       public void SetBorderColor(string bordercolor)
        {
            _borderColor = ValidationColor(bordercolor);
        }
        public void SetFillColor(string fillcolor)
        {
            _fillCOlor = ValidationColor(fillcolor);
        }
        public float GetRadius()
        {
            return _radius;
        }
        public string GetBorderColor()
        {
            return _borderColor;
        }
        public string GetFillColor()
        {
            return _fillCOlor;
        }
    }
}
