using System;

namespace SalaryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var managerSalary = EmployeeService.CalculateSalary(EmployeeType.Manager, 7);
            Console.WriteLine(string.Format("Manager's Salary: {0}", managerSalary));

            Console.ReadLine();
        }
    }
}
