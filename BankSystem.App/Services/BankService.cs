using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BankSystem.Class;

namespace BankSystem.App.Services
{
    public class BankService
    {
        // ( ** ) Метод для введения данных о расходах и доходах
        public List<int> ProfitAndCosts()
        {
            Console.WriteLine("Введите предполагаемые доходы: ");
            string i = Console.ReadLine();
            int I = int.Parse(i);

            Console.WriteLine("Введите предполагаемые Расходы: ");
            string j = Console.ReadLine();
            int J = int.Parse(j);

            List<int> ProfitCosts = new List<int> { I,J };
            ProfitCosts[0] = I;
            ProfitCosts[1] = J;
            return ProfitCosts;
        }
        // ( ** ) Метод для выведения предполагаемого количества акционеров банка
        public int AmountBankShareholders()
        {
            Console.WriteLine("Введите количество акционеров банка: ");
            string t = Console.ReadLine();
            int T = int.Parse(t);
            return T;
        }
        // ( ** ) Метод для расчета зарплаты акционера
        public double SalaryBankShareholders(List<int> profitandcosts, int amount) 
        {
            double salary = (profitandcosts[0] - profitandcosts[1])/amount;
            return salary;
        }
        // ( ** ) Метод для преобразования клиента банка в сотрудника
        public Employee Recruitment(Client client)
        {
            Employee employee = client;
            employee.Contract = "Трехлетний";
            employee.Salary = 1000;
            employee.Post = "Разработчик"; 
            return employee;

        }
        // ( ** ) Метод для добавления и обновления значения свойства Contract экземпляра класса Employee
        public string UpgradeContract(Employee employee)
        {
            Console.WriteLine("Введите наименование нового контракта: ");
            string offer = Console.ReadLine();
            employee.Contract = offer;
            return employee.Contract;
        }
    }
}
