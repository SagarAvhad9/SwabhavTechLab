using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationApp.Model
{[Serializable]
    class Serialization
    {
        private double _balance;
        private string _name;
        private int _accountNumber;

        public Serialization(double balance,string name,int accountNumber)
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
            if(camount<500)
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
