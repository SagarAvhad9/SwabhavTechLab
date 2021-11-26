using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountIdGenrate.Model
{
    class AccountId
    {
        private string _name;
        private float _balance;
        private GenderType _gender;
        private string _id;
        private static int _count;

        static AccountId()
        {
            _count = 1001;
        }
        public AccountId(string name,float balance)
        {
            _name = name;
            _balance = balance;
            _id = "c" + _count;
            _count += 1;
        }
        public AccountId(string name,GenderType gender,float balance)
        {
            _name = name;
            _gender = gender;
            _balance = balance;
            _id = "c" + _count;
            _count += 1;

        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public float Balance
        {
            get
            {
                return _balance;
            }
        }
        public GenderType Gender
        {
            get
            {
                return _gender;
            }
        }
        public string Id
        {
            get
            {
                return _id;
            }
        }
    }
}
