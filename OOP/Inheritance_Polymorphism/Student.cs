using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB8
{
    class Student:Person
    {
        private string program;
        private int year;
        private double fee;
        

        public  Student(string name,string address,string program,int year,double fee):base(name,address) 
        {
            this.program = program;
            this.year = year;
            this.fee = fee;
            this.name = name;
            this.address = address;
           
        }

        public string getProgram => program;
        public void setProgram(string value) => program = value;
        public int getYear => year;
        public void setYear(int value) => year = value;
        public double getFee => fee;
        public void setFee(double value) => fee=value;
        public override string toString => "Student["
            + base.toString + ",program=" + program + ",year=" + year + ",fee=" + fee + "]";







    }
}
