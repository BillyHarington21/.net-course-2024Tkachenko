using BankSystemDomen.Modelss;
using Bogus;
using System.Collections.Generic;
using System.Linq;


namespace BankSystem.App.Services
{
    public class TestDataGenerator
    {
        public List<Client> Clients()
        {
            var FakeClient = new Faker<Client>()
                 .RuleFor(c => c.Name, f => f.Name.FullName())
                 .RuleFor(c => c.Id, f => f.Random.Int(1, 1000))
                 .RuleFor(c => c.PhoneNumber, f => f.Phone.PhoneNumber())
                 .RuleFor(c => c.Age, f => f.Random.Int(20, 35));

            var clients = FakeClient.Generate(1000);
            return clients;
        }
        public List<Employee> Employees()
        {
            var employeeFaker = new Faker<Employee>()
                .RuleFor(e => e.Name, f => f.Name.FullName())
                .RuleFor(e => e.Id, f => f.Random.Int(1, 1000))
                .RuleFor(e => e.Contract, f => f.PickRandom(new[] { "Yearly", "Three-Year", "One-and-a-Half-Year" }))
                .RuleFor(e => e.Salary, f => f.Random.Decimal(500, 1000));

            var employees = employeeFaker.Generate(10);
            return employees;
        }
              
        public Dictionary<string, Client> DictionaryClients()
        {
           
            List<Client> clients = Clients();                           
            
            Dictionary<string, Client> clientDictionary = clients.ToDictionary(client => client.PhoneNumber, client => client);
            return clientDictionary;
        }
        
        
    }
}
