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
            Console.WriteLine("\nAdd an employee to the system");

            // Ask for Employee name
            Console.Write("What is the employee name: ");
            string employeeData = Console.ReadLine();
            if (employeeData != "") 
            {
                employee.Name = employeeData;
            }
            else
            {
                Console.Write("Please enter a valid name. What is the employee name: ");
                employeeData = Console.ReadLine();
            }


            // Set employeeID
            SetEmployeeID(employee);

            // Ask what Department they are in
            Console.Write("What department is employee assign to: ");
            employeeData = Console.ReadLine();
            if (employeeData != "")
            {
                employee.Department = employeeData;
            }
            else
            {
                Console.Write("Please enter a valid Department. What department is employee assign to: ");
                employeeData = Console.ReadLine();
            }

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

            Console.WriteLine($"You successfully added Employee Name: {employee.Name} - Employee ID: {employee.EmployeeID} to the system");

            return employee;
        }

        public static List<EmployeeModel> RemoveEmployee(string employeeID, List<EmployeeModel> employees) 
        {
            // loop through list of the employees
            for (int i = 0; i < employees.Count; i++) 
            {
                // check if employeeID matches
                if (employees[i].EmployeeID == employeeID)
                {
                    // remove employee
                    employees.RemoveAt(i);
                    break;
                    Console.WriteLine($"You successfully remove {employees[i].Name} from the system.");
                }
            }
            
            return employees;
          
        }

        public static void DisplayAllEmployees(List<EmployeeModel> employees) 
        {
            Console.WriteLine();
            foreach (var employee in employees)
            {
                Console.WriteLine($"Employee ID: {employee.EmployeeID} Employee Name: {employee.Name}");
            }
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
