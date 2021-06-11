using System;

namespace Part4Ex2
{
    public class Employee
    {
        private string firstName;
        private string lastName;
        private string address;
        private long sin;
        private double salary;

        public Employee(string firstName, string lastName, string address, long sin, double salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.sin = sin;
            this.salary = salary;
        }

        public Employee()
        {
        }

        public override string ToString()
        {
            return $"Name : {firstName} {lastName}, address: {address}, salary: {salary}, sin: {sin}";
        }

        public void Bonus()
        {
            Console.WriteLine("Enter first name:");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter last name:");
            lastName = Console.ReadLine();
            Console.WriteLine("Enter address:");
            address = Console.ReadLine();
            sin = 0349;
            Console.WriteLine("Enter salary:");
            salary = Convert.ToDouble(Console.ReadLine());
            int percentage = 20;
            double bonus = salary * percentage / 100;
            Console.WriteLine(ToString());
            Console.WriteLine($"Bonus: {bonus}");
        }

        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }

        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }

        public string Address
        {
            get => address;
            set => address = value;
        }

        public long Sin
        {
            get => sin;
            set => sin = value;
        }

        public double Salary
        {
            get => salary;
            set => salary = value;
        }
    }
}