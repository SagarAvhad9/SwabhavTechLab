using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnginneringApp.Model
{
    class Student:Person
    {
        private int _id;
        private string _address;
        private string _dateofbirth;
        private string _branch;

        public Student(int id, string address, string dateofbirth, string branch) : base(id, address, dateofbirth)
        {
            this._id = id;
            this._address = address;
            this._dateofbirth = dateofbirth;
            this._branch = branch;
        }
        public int Id
        {
            get
            {
                return _id;
            }
        }
        public string Address
        {
            get
            {
                return _address;
            }
        }
        public string DateOfBirth
        {
            get
            {
                return _dateofbirth;
            }
        }
        public string Branch
        {
            get
            {
                return _branch;
            }
        }
        public override string ExtraThings()
        {
            Console.WriteLine("Branch: " + _branch);
            return string.Empty;
        }
    }
}
