using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleEncapsulationApp.Model
{
    class Circle
    {
        private float Lower_Bound = 1;
        private float Upper_Bound = 10;
        private float _radius = 0;
        private string _bordercolor ;
        private string _fillcolor;
                public float CalculateArea()
        {
            return (3.14f*_radius*_radius);
        }
         private float ValidRadius(float value)
        {
            if(value<Lower_Bound)
            {
                Console.WriteLine("print value is set to 1",value);
                return Lower_Bound;

            }
            else if (value>Upper_Bound)
            {
                Console.WriteLine("print value is set to 10", value);
                return Upper_Bound;

            }
            else
            {
                return value;
            }
        }
         
        private string ValidColor(string color)
        {
            string defaultcolor = "red";

            if (color.ToLower() =="red"||color.ToLower()=="blue"||color.ToLower()=="green")
            {
                return color.ToLower();
            }
            else
            {
                return defaultcolor;
            }
        }

        public void SetRadius(float circleRadius)
        {
            _radius = ValidRadius(circleRadius);
        }
        public void SetBorderColor(string bordercolor)
        {
            _bordercolor = ValidColor(bordercolor);
        }
        public void SetFillColor(string Fillcolor)
        {
            _fillcolor = ValidColor(Fillcolor);
        }
        public float GetRadius()
        {
            return _radius;
        }
        public string GetBorderColor()
        {
            return _bordercolor;
        }
        public string GetFillColor()
        {
            return _fillcolor;
        }
        
    }
}
