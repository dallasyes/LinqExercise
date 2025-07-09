using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            var sum = numbers.Sum();
            Console.WriteLine($"Sum: {sum}");

            //TODO: Print the Average of numbers
            var avg = numbers.Average();
            Console.WriteLine($"Avg: {avg}");

            //TODO: Order numbers in ascending order and print to the console
            var ordered = numbers.OrderBy(x => x).ToArray();
            foreach (var num in ordered)
            {
                Console.WriteLine(num);
            }

            //TODO: Order numbers in descending order and print to the console
            var reverseordered = numbers.OrderByDescending(x => x).ToArray();
            foreach (var num in reverseordered)
            {
                Console.WriteLine(num);
            }

            //TODO: Print to the console only the numbers greater than 6
            var greaterthan6 = numbers.Where(x => x > 6).ToArray();
            foreach (var num in greaterthan6)
            {
                Console.WriteLine(num);
            }

            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**
            var only4 = numbers.OrderBy(x => x).Take(4).ToArray();
            foreach (var num in only4)
            {
                Console.WriteLine(num);
            }

            //TODO: Change the value at index 4 to your age, then print the numbers in descending order
            numbers[4] = 29;
            var agedesc = numbers.OrderByDescending(x => x).ToArray();
            foreach (var num in agedesc)
            {
                Console.WriteLine(num);
            }

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            var CorS = new List<Employee>();
            foreach (var employee in employees)
            {
                if (employee.FirstName.StartsWith("C") || employee.FirstName.StartsWith("S"))
                {
                    CorS.Add(employee);
                }
            }

            var orderedCorS = CorS.OrderBy(x => x.FirstName).ToArray();
            Console.WriteLine($"Names that start with C or S: ");
            foreach (var name in orderedCorS)
            {
                Console.WriteLine(name.FullName);
            }

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            var over26 = new List<Employee>();
            foreach (var employee in employees)
            {
                if (employee.Age > 26)
                {
                    over26.Add(employee);
                }
            }

            var over26a = over26.OrderBy(x => x.Age).ThenBy(x => x.FirstName).ToArray();
            foreach (var employee in over26a)
            {
                Console.WriteLine(employee.FullName); 
            }
            
            //TODO: Print the Sum of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            var tenand35 = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).Sum(x => x.YearsOfExperience);
            Console.WriteLine($"{tenand35}");
            
            //TODO: Now print the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            var avg10and35 = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35)
                .Average(x => x.YearsOfExperience);
            Console.WriteLine($"{avg10and35}");

            //TODO: Add an employee to the end of the list without using employees.Add()
            var Dallas = new Employee();
            employees.Append(Dallas);


            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
