using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetGenericApp.Model
{
    class Student
    {
        private int _rollNo;
        private string _name;
        private string _location;
        public Student(int rollNo,string name,string location)
        {
            _rollNo = rollNo;
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
            return _rollNo;
        }
        public override bool Equals(object obj)
        {
            Student studentsObj = (Student)obj;
            if (this._rollNo == studentsObj._rollNo)
                return true;
            return false;
        }
    }
}
