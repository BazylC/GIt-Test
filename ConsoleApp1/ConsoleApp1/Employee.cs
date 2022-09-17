using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }

        public Contract Contract { get; set; }

        public Employee()
        {
            
        }


        public Employee(string firstName, string secondName, Contract contract)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.Contract = contract;
        }

        public void ChangeContract(Contract contract)
        {
            this.Contract = contract;
        }

        public double Salary()
        {
            return this.Contract.Salary();
        }

        public override string ToString()
        {
            return $"{FirstName} {SecondName} have {Salary()} salary";
        }
    }
}
