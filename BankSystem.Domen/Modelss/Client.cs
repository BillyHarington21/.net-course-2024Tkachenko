using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemDomen.Modelss
{
    public class Client : Employee
    {
        public string PhoneNumber { get; set; }
        public int Age { get; set; }

        /*public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            var other = (Client)obj;
            return this.Id.GetHashCode() == other.Id.GetHashCode();
        }*/

    }
}
