using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherLib.Publisher
{
    public class Account
    {
        private int _accno;
        private string _name;
        private double _balance;
        private int _mobileNo;
        private string _email;
        private List<INotifier> notifier1 = new List<INotifier>(); 

        public Account(int accno, string name, double balance)
        {
            this._accno = accno;
            this._name = name;
            this._balance = balance;
        }
        public void Deposit(double amt)
        {
            _balance += amt;
            Notify();
        }
        public void Withdraw(double amt)
        {
            _balance -= amt;
            Notify();
        }
        private void Notify()
        {
            foreach (INotifier notifier in notifier1)
            {
                notifier.Notify(this);
            }
        }
        public void AddNotifier(INotifier notifier)
        {
            notifier1.Add(notifier);
        }
        public int AccNO
        {
            get
            {
                return _accno;
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
