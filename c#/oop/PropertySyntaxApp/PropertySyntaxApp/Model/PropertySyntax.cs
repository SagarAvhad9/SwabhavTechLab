using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertySyntaxApp.Model
{
    class PropertySyntax
    {
        private int _bar;
        private int _baz;

        public PropertySyntax()
        {
            Random r = new Random();
            _baz = r.Next(0, 2);

        }
        public int Bar
        {
            get
            {
                return _bar;
            }
            set
            {
                if (value > 0)
                {
                    _bar = value;
                }
            }
        }
        public int Baz
        {
            get
            {
              return _baz;
            }
        }
    }
}
