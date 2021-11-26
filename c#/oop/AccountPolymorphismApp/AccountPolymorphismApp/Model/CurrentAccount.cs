using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphismApp.Model
{
    class CurrentAccount:Account
    {
        public CurrentAccount(int accno,string name,double balance):base(accno,name,balance)
        {

        }
        public override void WithDraw(double amt)
        {
            if (DoOverDraftCheck())
            {
                _balance -= amt;
            }
            else
            {
                Console.WriteLine("cant withdraw");
            }
        }

        private bool DoOverDraftCheck()
        {
            return true;
        }
    }
}
