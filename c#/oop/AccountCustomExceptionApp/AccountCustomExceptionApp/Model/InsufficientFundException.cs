using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountCustomExceptionApp.Model
{
    class InsufficientFundException:Exception
    {
        private string _message;
        public InsufficientFundException(Account acc,double amount)
        {
            _message = $"cant withdraw from account {acc.AccNo}+" +
                       $"\nyou are trying to withdraw {amount}+" +
                       $"\nyou can withdraw {acc.Balance-500}";
        }
        public override string Message
        {
            get 
            { 
                return _message; 
            }
           
        }
    }
}
