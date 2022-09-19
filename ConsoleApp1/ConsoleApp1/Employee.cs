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

        public IContract contract;

        public Employee()
        {
            
        }


        public Employee(string firstName, string secondName, IContract contract)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.contract = contract;
        }

        public void ChangeContract(Contract contract)
        {
            this.contract = contract;
        }

        public double Salary()
        {
            return this.contract.Salary();
        }

        public override string ToString()
        {
            return $"{FirstName} {SecondName} have {Salary()} salary";
        }
    }
}
