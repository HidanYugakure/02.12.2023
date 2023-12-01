using System.Security.Cryptography.X509Certificates;

namespace _02._12._2023.Employee
{
    internal class Employee
    {
        private static Employee employe2;

        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; }
        public decimal Salary { get; set; }

        public Employee(string name, string surname, DateTime birthday, decimal salary)
        {
            Name = name;
            Surname = surname;
            Birthday = birthday;
            Salary = salary;
        }
        public Employee()
        {
        }

        public static Employee[] InfoMethod()
        {
            Employee employe1 = new Employee("Islam", "Adisirinli", new DateTime(2004, 3, 19), 2500);
            Employee employe2 = new Employee("Fuad", "Iskenderov", new DateTime(2002, 7, 17), 2200);
            Employee employe3 = new Employee("Fidan", "Suleymanli", new DateTime(1999, 1, 7), 4100);
            Employee employe4 = new Employee("Teymur", "Mamedov", new DateTime(2005, 11, 8), 800);

            Employee[] Emp = { employe1, employe2, employe3, employe4 };
            return Emp;
        }

        public int MethodDateSalary (DateTime StartDate,DateTime EndDate, int MinSalary)
        {
            int count = 0;

            Employee[] TamInfo=InfoMethod();
           
            foreach (Employee employee in TamInfo)
            {

                if (employee.Birthday >= StartDate && employee.Birthday <= EndDate && employee.Salary > MinSalary)
                {
                    count++;
                }
            }

            return count;
        }
    }
 }


