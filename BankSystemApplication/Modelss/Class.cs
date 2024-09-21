
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class Class
    {
        public class Person
        {
            public int id {  get; set; }
            public string name  { get; set; }
        }
        public class Employee : Person
        {
            public string Contract { get; set; }
            public double Salary { get; set; }
            public string Post {  get; set; }
        }
        public class Client : Employee
        {
            
        }
        public struct Currency 
        {
            public string Name { get; set; }
            public int Id { get; set; }
            public string Country { get; set; }

            public Currency(string name, string country, int id)
            {
                Name = name;
                Country = country;
                Id = id;
            }
        }
        
    }

}
