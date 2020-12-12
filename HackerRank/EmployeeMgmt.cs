using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Solution
{
    public class Solution
    {

        public static Dictionary<string, int> AverageAgeForEachCompany(List<Employee> employees)
        {

            Dictionary<string, int> result = new Dictionary<string, int>();
            var listComp = employees.Select(x=>x.Company).Distinct().ToList();

            foreach (var comp in listComp)
            {
                var empAgeAvg = (from emp in employees
                                    where emp.Company == comp
                                    select emp.Age).Average();
                result.Add(comp, (int)empAgeAvg);
            }
            return result;
        }
        
        public static Dictionary<string, int> CountOfEmployeesForEachCompany(List<Employee> employees)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            var listComp = employees.Select(x => x.Company).Distinct().ToList();

            foreach (var comp in listComp)
            {
                var empCount = (from emp in employees
                                    where emp.Company == comp
                                    select emp).Count();
                result.Add(comp, (int)empCount);
            }
            return result;
        }
       
        public static Dictionary<string, Employee> OldestAgeForEachCompany(List<Employee> employees)
        {
            Dictionary<string, Employee> res = new Dictionary<string, Employee>();
            //TODO
            return res;
        } 

        public static void Main()
        {
            int countOfEmployees = int.Parse(Console.ReadLine());

            var employees = new List<Employee>();

            for (int i = 0; i < countOfEmployees; i++)
            {
                string str = Console.ReadLine();
                string[] strArr = str.Split(' ');
                employees.Add(new Employee
                {
                    FirstName = strArr[0],
                    LastName = strArr[1],
                    Company = strArr[2],
                    Age = int.Parse(strArr[3])
                });
            }

            foreach (var emp in AverageAgeForEachCompany(employees))
            {
                Console.WriteLine($"The average age for company {emp.Key} is {emp.Value}");
            }
           
            foreach (var emp in CountOfEmployeesForEachCompany(employees))
            {
                Console.WriteLine($"The count of employees for company {emp.Key} is {emp.Value}");
            }
 
            foreach (var emp in OldestAgeForEachCompany(employees))
            {
                Console.WriteLine($"The oldest employee of company {emp.Key} is {emp.Value.FirstName} {emp.Value.LastName} having age {emp.Value.Age}");
            } 
        }
    }

    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Company { get; set; }
    }
}