using System.Diagnostics.Metrics;
using System.Xml.Linq;
using static BankSystem.Class;

class Programm
{
    static void Main(string[] args)
    {
        Employee employee = new Employee() { id = 1, name = "Antip" };        
        
        UpgradeContract(employee);

        Console.WriteLine($"{employee.id}\t{employee.name}\t{employee.Contract}");

        Currency currency = new Currency();
        UpgradeCurrency(ref currency, currency.Id, currency.Name, currency.Country);
        Console.WriteLine($"{currency.Id}\t{currency.Name}\t{currency.Country}");
    }
    // (   ) Метод для добавления и обновления значения свойства Contract класса Employee
    static void UpgradeContract(Employee employee)
    {
        Console.WriteLine("Введите наименование нового контракта: ");
        string? offer = Console.ReadLine();
        employee.Contract = offer;
    }
    // (   ) Метод для добавления и обновления значений всех свойств структуры Currency 
    static void UpgradeCurrency(ref Currency currency, int Id, string Name, string Country)
    {
        Console.WriteLine("Введите название валюты: ");
        currency.Name = Console.ReadLine();
        Console.WriteLine("Введите название страны обихода валюты: ");
        currency.Country = Console.ReadLine();
        Console.WriteLine("Введите идентификационный номер: ");
        string? q = Console.ReadLine();
        int id = int.Parse(q);
        currency.Id = id;  
        
        
    }
}

