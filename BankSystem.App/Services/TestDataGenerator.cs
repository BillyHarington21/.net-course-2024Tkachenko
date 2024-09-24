using BankSystemDomen.Modelss;
using Bogus;
using System.Collections.Generic;


namespace BankSystem.App.Services
{
    public class TestDataGenerator
    {
        // нуно добавить возраст клиента!!!
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
        // создаю класс для удобства работы со словарем, тк словарь создаю из элементов списка и для исследований нуно, чтобы данные списка клиентов и словаря клиентов были одиннаковыми 
        public class ClientInDictionary
        {
            public Dictionary<string, Client> ClientDictionary { get; set; }
            public List<Client> Clients { get; set; }
        }
        public ClientInDictionary DictionaryClients()
        {
           
            List<Client> clients = Clients();
                            
            var ClientDictionary = new Dictionary<string, Client>();

            foreach (var client in clients)
            {
                if (!ClientDictionary.ContainsKey(client.PhoneNumber))                                  
                    ClientDictionary[client.PhoneNumber] = client;                 
            }
            return new ClientInDictionary()
            {
                ClientDictionary = ClientDictionary,
                Clients = clients
            }; ;
        }
    }
}
