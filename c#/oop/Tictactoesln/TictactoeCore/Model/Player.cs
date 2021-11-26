using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TictactoeCore.Model
{
    public class Player
    {
        private string _name;
        private MarkType _mark;
        public Player(string name,MarkType mark)
        {
            this._name = name;
            this._mark = mark;
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public MarkType Mark
        {
            get
            {
                return _mark;
            }
        }
    }
}
