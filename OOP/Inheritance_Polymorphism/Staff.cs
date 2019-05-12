using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB8
{
    class Staff:Person
    {
        private string school;
        private double pay;

        public Staff(string name,string address,string school, double pay) : base(name,address)
        {
            this.school = school;
            this.pay = pay;
            this.name = name;
            this.address = address;
        }

        public string getSchool => school;
        public void setSchool(string school) => this.school = school;
        public double getPay => pay;
        public void setPay(double pay) => this.pay=pay;

        public override string toString => "Staff[" + base.toString + ",school=" + school + ",pay=" + pay + "]";


    }
}
