using BankSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemDomen.Modelss
{
    public class Employee  :  Person
    {
        public string Contract { get; set; }
        public decimal Salary { get; set; }
        public string Post { get; set; }
    }
}
