using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDictApp.Model
{
    class Student
    {
        private int _rollNo;
        private int _standard;
        private string _name;
        private string _location;
        public Student(int rollNo,int standard, string name, string location)
        {
            _rollNo = rollNo;
            _standard = standard;
            _name = name;
            _location = location;
        }
        public int RollNo
        {
            get
            {
                return _rollNo;
            }
        }
        public int Standard
        {
            get
            {
                return _standard;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public string Location
        {
            get
            {
                return _location;
            }
        }
        public override int GetHashCode()
        {
            string hashcode = Convert.ToString(_rollNo) + Convert.ToString(_standard);
            return int.Parse(hashcode);
        }
        public override bool Equals(object obj)
        {
            Student studentsObj = (Student)obj;
            if (this._rollNo == studentsObj._rollNo && this._standard==studentsObj._standard)
                return true;
            return false;
        }
    }
}
