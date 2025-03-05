using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class EmployeeLogic
    {
        public static EmployeeModel AddEmployee()
        {
            EmployeeModel employee = new EmployeeModel();
            Console.WriteLine("Add an employee to the system\n");

            // Ask for Employee name
            Console.Write("What is the employee name: ");
            string employeeData = Console.ReadLine();
            employee.Name = employeeData;

            // Set employeeID
            SetEmployeeID(employee);

            // Ask what Department they are in
            Console.Write("What department is employee assign to: ");
            employeeData = Console.ReadLine();

            // Ask what is the employee salary
            Console.Write("What is the salary for the employee: ");
            employeeData = Console.ReadLine();
            int salary;
            bool isValidSalary = int.TryParse(employeeData, out salary);

            while (isValidSalary == false)
            {
                Console.WriteLine("That was not a valid number. Please try again. ");
                Console.Write("What is the salary for the employee: ");
                employeeData = Console.ReadLine();
                isValidSalary = int.TryParse(employeeData, out salary);
            }
            employee.Salary = salary;   

            return employee;
        }

        public static void RemoveEmployee() 
        { 
        }

        public static void DisplayAllEmployees() 
        { 
        
        }

        public static void SetEmployeeID(EmployeeModel employee)
        {

            Random rnd = new Random();
            string nums = "1234567890";
            int MAX_LENGTH = 9;
            string empID = string.Empty;

            for (int i = 0; i < MAX_LENGTH; i++)
            {
                int temp = rnd.Next(10);
                empID += nums.ElementAt(temp);
                employee.EmployeeID = empID;

            }

        }

    }
}
