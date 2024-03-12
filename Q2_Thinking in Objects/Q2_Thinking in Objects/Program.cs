using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_Thinking_in_Objects
{

    internal class program
    {
        static void Main(string[] args)
        {
            Company company = new Company { Name = "MyCompany", IncorporatedDt = DateTime.Today };

            Branch b1 = new Branch();
            Branch b2 = new Branch();
            company.Branches.Add(b1);
            company.Branches.Add(b2);

            Employee e1 = new Employee { Name = "abc", Age = 30, Address = "Bangalore", EmpId = 1, Basic = 10000, Experience = 4 };
            Employee e2 = new Employee { Name = "xyz", Age = 32, Address = "Bangalore", EmpId = 2, Basic = 20000, Experience = 6 };
            Employee e3 = new Employee { Name = "pqr", Age = 26, Address = "Bangalore", EmpId = 3, Basic = 15000, Experience = 2 };
            company.Employees.Add(e1);
            company.Employees.Add(e2);
            company.Employees.Add(e3);

            Customer c1 = new Customer { Name = "aaa", Age = 25, Address = "Bangalore", CustomerId = 11, Email = "c1@gmail.com" };
            Customer c2 = new Customer { Name = "bbb", Age = 35, Address = "Bangalore", CustomerId = 12, Email = "c2@gmail.com" };
            company.Customers.Add(c1);
            company.Customers.Add(c2);

            Employee emp = company.GetEmployee(2);
            Console.WriteLine($"Employee with id 2 :\n Name =  {emp.Name}\n Age = {emp.Age}\n Address =  {emp.Address}\n Basic = {emp.Basic}\n Experience = {emp.Experience} \n ");

            Console.WriteLine("Total Salary Payout : " + company.GetTotalSalaryPayout());
            Console.WriteLine("Total Employess : " + company.GetTotalEmployess());
            Console.WriteLine("Total Customers : " + company.GetTotalCustomers());
        }
    }
    class Company
    {
        public string Name { get; set; }
        public DateTime IncorporatedDt { get; set; }
        public List<Branch> Branches { get; set; } = new List<Branch>();
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public List<Customer> Customers { get; set; } = new List<Customer> { };
        public Employee GetEmployee(int EmpId)
        {
            foreach (Employee emp in Employees)
            {
                if (emp.EmpId == EmpId)
                { return emp; }
            }
            return null;
        }
        public double GetTotalSalaryPayout()
        {
            double SalaryPayout = 0;
            foreach (var emp in Employees)
            {
                SalaryPayout += emp.GetSalary();
            }
            return SalaryPayout;
        }
        public int GetTotalCustomers()
        {
            return Customers.Count;
        }
        public int GetTotalEmployess()
        {
            return Employees.Count;
        }
    }
    class Branch
    {
        public string Reg { get; set; }
        public string Corp { get; set; }
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }


    }
    class Employee : Person
    {
        public int EmpId { get; set; }
        public double Basic { get; set; }
        public double Experience { get; set; }

        internal SalaryCalculator SalaryCalculator
        {
            get => default(Company.SalaryCalculator);
            set
            {
            }
        }

        public double GetSalary()
        {
            double TotalSalary = 0;
            double Allowance = SalaryCalculator.CalculateSalary(Experience, Basic);
            TotalSalary = Basic + Allowance;
            return TotalSalary;
        }
    }
    class Customer : Person
    {
        public int CustomerId { get; set; }
        public string Email { get; set; }

    }
    class SalaryCalculator
    {
        public static double CalculateSalary(double Experience, double Basic)
        {
            double Allowance;

            if (Experience <= 2)
            {
                Allowance = (30 * Basic / 100);

            }

            else if (Experience <= 4)
                Allowance = (40 * Basic / 100);

            else if (Experience <= 6)
                Allowance = (50 * Basic / 100);

            else
                Allowance = (65 * Basic / 100);

            return Allowance;

        }
    }
}

