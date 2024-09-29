using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemDomen.Modelss
{
    public class Account
    {
        public Currency Currency { get; set; }
        public decimal Amount { get; set; }
        public override bool Equals(object obj)
        {
            if (obj is Account account)
            {
                return this.Amount == account.Amount;
            }
            else return false;
        }
    }
}
