using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Contract : IContract
    {
        protected double Pay{ get; set; }
        protected int OverTime { get; set; }

        public Contract()
        {

        }

        public Contract(double pay, int overTime)
        {
            this.Pay = pay;
            this.OverTime = overTime;
        }

        public abstract double Salary();
     
    }
}
