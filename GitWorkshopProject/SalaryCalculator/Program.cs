using System;

namespace SalaryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var managerSalary = EmployeeService.CalculateSalary(EmployeeType.Manager, 7);
            Console.WriteLine(string.Format("Manager's Salary: {0}", managerSalary));
            
            var ExpertSalary = EmployeeService.CalculateSalary(EmployeeType.Expert, 9);
            Console.WriteLine(string.Format("Expert's Salary: {0}", ExpertSalary));

            Console.ReadLine();
        }
    }
}
