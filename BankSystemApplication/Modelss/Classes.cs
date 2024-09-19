using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemApplication
{
    public abstract class Classes
    {
        public class Person
        {
            public int id {  get; set; }
            public string name  { get; set; }
        }
        public class Employee : Person
        {
            public string Contract { get; set; }
        }
        public class Client : Person
        {
            
        }
        public struct Currency 
        {

        }
    }

}
