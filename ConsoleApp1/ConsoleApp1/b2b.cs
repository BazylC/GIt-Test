using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class B2b : Contract
    {
        public B2b()
        {
            Pay = 7500;
        }

        public B2b(double pay, int overTime) : base(pay,overTime)
        {

        }

        public override double Salary()
        {
            return Math.Round(this.Pay + OverTime * (Pay / 20));
        }
    }
}
