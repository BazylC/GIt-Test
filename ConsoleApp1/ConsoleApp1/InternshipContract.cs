using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class InternshipContract : Contract
    {
        public InternshipContract()
        {
            Pay = 1000;
        }

        public InternshipContract(double pay, int overTime) : base(pay, overTime)
        {

        }

        public override double Salary()
        {
            return Math.Round(this.Pay);
        }
    }
}
