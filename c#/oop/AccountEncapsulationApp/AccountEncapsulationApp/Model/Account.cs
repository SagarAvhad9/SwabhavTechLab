using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountEncapsulationApp.Model
{
    class Account
    {
        private double _balance;
        private string _name;
        private int _accountNumber;

        public Account(int accountNumber, string name, double balance)
        {
            _balance = balance;
            _name = name;
            _accountNumber = accountNumber;
        }

        public void Deposit(double amount)
        {
            _balance = _balance + amount;

        }
        public void Withdraw(double amount)
        {

            double camount = _balance;
            camount = camount - amount;//1000-501=499 you cant
            if (camount < 500)
            {
                Console.WriteLine("you can not withdraw");
            }
            else
            {
                _balance -= amount;
            }

        }

        public double Balance
        {
            get
            {
                return _balance;
            }
        }
        public String Name
        {
            get
            {
                return _name;
            }
        }
        public int AccountNumber
        {
            get
            {
                return _accountNumber;
            }
        }
        
    }
}
