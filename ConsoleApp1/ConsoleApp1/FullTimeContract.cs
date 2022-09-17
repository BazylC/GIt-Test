using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class FullTimeContract : Contract
    {
        public FullTimeContract()
        {
            Pay = 5000;
            OverTime = 0;
        }

        public FullTimeContract(double pay, int overTime) : base(pay, overTime)
        {

        }
   
        public override double Salary()
        {
            return Math.Round(this.Pay + (OverTime * (Pay / 60)));
        }
    }
}
