using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<EmployeeModel> employees = new List<EmployeeModel>();

            UserMessages.WelcomeMessages();

            EmployeeModel bob = new EmployeeModel();

            bob = EmployeeLogic.AddEmployee();

            Console.ReadLine();
        }
    }
}
