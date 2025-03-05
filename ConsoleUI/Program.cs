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
            string userInput;

            UserMessages.WelcomeMessages();

            // Add employees to the system
            do
            {
                employees.Add(EmployeeLogic.AddEmployee());

                Console.Write("Do you want to add another employee? (yes/no): ");
                userInput = Console.ReadLine();

                // Break out of the loop if the user doesn't want to add another employee
                if (userInput.ToLower() != "yes")
                {
                    break;
                }

            } while (true); // Infinite loop, but we break out of it based on user input

            // Remove employees from the system
            do
            {
                Console.Write("Do you want to remove an employee? (yes/no): ");
                userInput = Console.ReadLine();

                if (userInput.ToLower() == "yes")
                {
                    Console.Write("What is the employee ID that you want to remove from the system: ");
                    string removeEmployeeID = Console.ReadLine();
                    EmployeeLogic.RemoveEmployee(removeEmployeeID, employees);
                }
                else
                {
                    break; // Exit the loop if the user doesn't want to remove another employee
                }

            } while (true); // Infinite loop, but we break out of it based on user input

            // Display all employees
            EmployeeLogic.DisplayAllEmployees(employees);

            Console.ReadLine();
        }
    }
}
