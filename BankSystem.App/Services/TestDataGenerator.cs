using BankSystemDomen.Modelss;
using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;


namespace BankSystem.App.Services
{
    public class TestDataGenerator
    {
        public List<Client> Clients(int amount)
        {
            var FakeClient = new Faker<Client>()
                 .RuleFor(c => c.Name, f => f.Name.FullName())
                 .RuleFor(c => c.Id, f => f.Random.Int(1, 1000))
                 .RuleFor(c => c.PhoneNumber, f => f.Phone.PhoneNumber())
                 .RuleFor(c => c.Age, f => f.Random.Int(20, 35));

            var clients = FakeClient.Generate(amount);
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
           
            List<Client> clients = Clients(1000);                           
            
            Dictionary<string, Client> clientDictionary = clients.ToDictionary(client => client.PhoneNumber, client => client);
            return clientDictionary;
        }

        public Dictionary<int, List<Account>> DictionaryAccountsOfClients(Dictionary<string, Client> dictionaryClients)
        {         
            var fakeAccount = new Faker<Account>()
                .RuleFor(a => a.Currency, a => new Currency { Name = a.PickRandom(new[] { "USD", "EUR", "RUB" }) })
                .RuleFor(a => a.Amount, a => a.Random.Decimal(500, 10000));

            Dictionary<int, List<Account>> clientsAccount = new Dictionary<int, List<Account>>();
            foreach (var client in dictionaryClients)
            {
                int amountAccount = new Random().Next(1, 5);
                List<Account> accounts = fakeAccount.Generate(amountAccount);
                clientsAccount[client.Value.GetHashCode()] = accounts;
            }
            return clientsAccount;
        }


    }
}
