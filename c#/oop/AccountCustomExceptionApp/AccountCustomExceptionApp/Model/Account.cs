using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountCustomExceptionApp.Model
{
    class Account
    {
        private int _accNo;
        private string _name;
        private double _balance;
        public Account(int accNo, string name, double amount)
        {
            _accNo = accNo;
            _name = name;
            _balance = amount;
        }

        public void Deposit(double amount)
        {
            _balance += amount;
        }

        public void Withdraw(double amount)
        {
            if(_balance - amount > 500)
            {
                _balance -= amount;
            }
            throw new InsufficientFundException(this,amount);
        }
        public int AccNo
        {
            get 
            { 
                return _accNo; 
            }
        }
        public string Name
        {
            get 
            { 
                return _name; 
            }
        }
        public double Balance
        {
            get 
            { 
                return _balance; 
            }
        }


    }
}
