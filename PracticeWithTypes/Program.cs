using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Xml.Linq;
using static BankSystem.Class;
using BankSystem.App.Services;

class Programm
{
    static void Main(string[] args)
    {
        //** инициализируем класс BankService библиотеки классов
        BankService bankService = new BankService();

        //   (______)   Код для практического задания темы Типы значений и ссылочные типы 

              Employee employee = new Employee() { id = 1, name = "Antip" };

              //** вызываем для добавления и обновления значения свойства Contract класса Employee
              bankService.UpgradeContract(employee);

              Console.WriteLine($"{employee.id}\t{employee.name}\t{employee.Contract}");

              Currency currency = new Currency();

              //** вызываем Метод для добавления и обновления значений всех свойств структуры Currency
              UpgradeCurrency(ref currency, currency.Id, currency.Name, currency.Country);
              Console.WriteLine($"{currency.Id}\t{currency.Name}\t{currency.Country}");

        //   (______)

        //   (______)   Код для практического задания темы Привидение и преобразование типов

              List<int> Money = bankService.ProfitAndCosts();//** вызываем метод для введения данных о доходах и расходах и сразу присваиваем эти значения

              int Amount = bankService.AmountBankShareholders();//**  вызываем метод для введения данных о количестве акционеров банка и сразу присваиваем это значение

              Employee shareholder = new Employee() { id = 2, name = "Vasya", Post = "Shareholder" };

              shareholder.Salary = bankService.SalaryBankShareholders(Money, Amount);//** вызываем метод для расчета дохода Одного конретного владельца из расчета, что доля у всех акционеров одиннаковая
              Console.WriteLine($"{shareholder.id}\t{shareholder.name}\t{shareholder.Post}\t{shareholder.Salary}");

              Client client = new Client() { id = 12, name = "Foma"};
              Employee NewEmployee = bankService.Recruitment(client);
              Console.WriteLine($"{NewEmployee.id}\t{NewEmployee.name}\t{NewEmployee.Contract}\t{NewEmployee.Post}\t{NewEmployee.Salary}");

        //   (______)
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
