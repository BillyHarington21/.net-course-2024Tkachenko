using BankSystemDomen.Modelss;
using System;
using System.Collections.Generic;

namespace BankSystem.App.Services
{
    public class BankService
    {    
        // ( ** ) Метод для расчета зарплаты акционера
        public double SalaryBankShareholders() 
        {
            Console.WriteLine("Введите предполагаемые доходы: ");
            string i = Console.ReadLine();
            int I = int.Parse(i);

            Console.WriteLine("Введите предполагаемые Расходы: ");
            string j = Console.ReadLine();
            int J = int.Parse(j);

            List<int> ProfitCosts = new List<int> { I, J };
            ProfitCosts[0] = I;
            ProfitCosts[1] = J;

            Console.WriteLine("Введите количество акционеров банка: ");
            string t = Console.ReadLine();
            int amount = int.Parse(t);

            decimal salary = (ProfitCosts[0] - ProfitCosts[1])/amount;
            return (double)salary;
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
        
    }
}
