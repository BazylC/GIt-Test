using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new InternshipContract();

            Employee emp = new Employee("Bazyli", "Kondratrowicz", c1);

            var c2 = new FullTimeContract(7000, 10);

            emp.ChangeContract(c2);

            var c3 = new B2b();

            var emp2 = new Employee("Jan", "Kowalski", c3);

            Console.WriteLine(emp);
            Console.WriteLine(emp2);
            Console.WriteLine(emp);
        }
    }
}
