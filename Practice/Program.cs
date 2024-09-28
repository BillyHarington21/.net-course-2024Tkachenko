using BankSystem.App.Services;
using System.Diagnostics;
using BankSystemDomen.Modelss;

class Programm
{
    delegate int Number();
    static void Main(string[] args)
    {        
        /*
        //   (______)   Код для практического задания темы Типы значений и ссылочные типы 

        Employee employee = new Employee() { Id = 1, Name = "Antip" };

        //** вызываем метод для добавления и обновления значения свойства Contract класса Employee
        UpgradeContract(employee);

        Console.WriteLine($"{employee.Id}\t{employee.Name}\t{employee.Contract}");

        Currency currency = new Currency();

        //** вызываем Метод для добавления и обновления значений всех свойств структуры Currency
        UpgradeCurrency(ref currency);
        Console.WriteLine($"{currency.Id}\t{currency.Name}\t{currency.Country}");

        //   (______)

        //   (______)   Код для практического задания темы Привидение и преобразование типов

        //** инициализируем класс BankService библиотеки классов
        BankService bankService = new BankService();

        Employee shareholder = new Employee() { Id = 2, Name = "Vasya", Post = "Shareholder" };

        shareholder.Salary = (decimal)bankService.SalaryBankShareholders();//** вызываем метод для расчета дохода Одного конретного владельца из расчета, что доля у всех акционеров одиннаковая
        Console.WriteLine($"{shareholder.Id}\t{shareholder.Name}\t{shareholder.Post}\t{shareholder.Salary}");

        Client client = new Client() { Id = 12, Name = "Foma" };
        Employee NewEmployee = bankService.Recruitment(client);
        Console.WriteLine($"{NewEmployee.Id}\t{NewEmployee.Name}\t{NewEmployee.Contract}\t{NewEmployee.Post}\t{NewEmployee.Salary}");

        //   (______)*/

        TestDataGenerator testDataGenerator = new TestDataGenerator();
        Stopwatch stopwatch = new Stopwatch();
        
             
        List<Client> BankClients =  testDataGenerator.Clients();
        Random random = new Random();
        Number Num;
        int ClientNumber()
        {
            int I = random.Next(1, 1000);
            return I;
        }
        Num = ClientNumber;
        
        // поиск клиента по его номеру в списке
        var searchedClientPhone = BankClients[Num()].PhoneNumber;

        stopwatch.Start();
        for (int i = 0; i <= 9; i++)
        {
            var SearchedClient = BankClients.FirstOrDefault(client => client.PhoneNumber == searchedClientPhone);
        }
        stopwatch.Stop();

        Console.WriteLine("{0}",stopwatch.ElapsedMilliseconds);
        stopwatch.Reset();

        // поиск выборки клиентов младше определенного возраста
        int age = 25;

        stopwatch.Start();
        for (int i = 0; i <= 9; i++)
        {
            var searchedClientToAge = BankClients.Where(Client => Client.Age > age).ToList();
        }
        stopwatch.Stop();

        Console.WriteLine("{0}", stopwatch.ElapsedMilliseconds);
        stopwatch.Reset();

        // поиск клиента по его номеру из словаря
        var clientsInDictionary = testDataGenerator.DictionaryClients();
        var listClientFromDictionary = clientsInDictionary.ToList();
        var searchedClientPhoneInList = listClientFromDictionary[Num()].Value.PhoneNumber;// берем номер из списка клиентов из которого и составили словарь
       
        stopwatch.Start();
        for (int i = 0; i<= 9; i++)
        {
            var SearchedClientInDictionary = clientsInDictionary[searchedClientPhoneInList]; 
        }           
        stopwatch.Stop();

        Console.WriteLine("{0}", stopwatch.ElapsedMilliseconds);
        stopwatch.Reset();

        // поиск сотрудника по минимальной заработной плате
        List<Employee> employees = testDataGenerator.Employees(); 

        stopwatch.Start();
        for (int i = 0; i <= 9; i++)
        {
            var employeeWithMinSalary = employees.MinBy(employees => employees.Salary);
        }
        stopwatch.Stop();
        stopwatch.Reset();

        // сравнение способов поиска послднего элемента словаря (берем дланные из метода выше)
        var keyOfLastClientInDictionary = clientsInDictionary.Last();
        stopwatch.Start();
       // for (int i = 0; i <= 9; i++)
        {
            var lastClientInDictionary1 = clientsInDictionary.FirstOrDefault(s => s.Key == keyOfLastClientInDictionary.Key);
        }
        stopwatch.Stop();
        long fistWayFindLastClientInDictionary = stopwatch.ElapsedTicks; 

        stopwatch.Start();
       // for (int i = 0; i <= 9; i++)
        {
            var lastClientInDictionary2 = clientsInDictionary[keyOfLastClientInDictionary.Key];
        }
        stopwatch.Stop();
        long secondWayFindLastClientInDictionary = stopwatch.ElapsedTicks; 

        long EffectiveWay = Math.Min(fistWayFindLastClientInDictionary, secondWayFindLastClientInDictionary);
        if ( EffectiveWay == secondWayFindLastClientInDictionary)
        {
            Console.WriteLine("способ 2 быстрее");
        }
        else if (EffectiveWay == fistWayFindLastClientInDictionary) 
        {
            Console.WriteLine("способ 1 быстрее"); 
        }

    }

    // (   ) Метод для добавления и обновления значений всех свойств структуры Currency 
    static void UpgradeCurrency(ref Currency currency)
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
    // ( ** ) Метод для добавления и обновления значения свойства Contract экземпляра класса Employee
    static  string UpgradeContract(Employee employee)
    {
        Console.WriteLine("Введите наименование нового контракта: ");
        string offer = Console.ReadLine();
        employee.Contract = offer;
        return employee.Contract;
    }


}
