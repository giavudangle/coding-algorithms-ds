using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Date
    {
        // Declare member varriables
        private int day;
        private int month;
        private int year;

        // Building methods base on the design
        public Date(int day,int month,int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public int getDay
        {
            get
            {
                return this.day;
            }
        }

        public int getMonth
        {
            get
            {
                return this.month;
            }
        }

        public int getYear
        {
            get
            {
                return this.year;
            }
        }

        public void setDay(int day)
        {
            this.day = day;
        }

        public void setMonth(int month)
        {
            this.month = month;
        }

        public void setYear(int year)
        {
            this.year = year;
        }

        public void setDate(int day,int month,int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public string toString()
        {
            return day + "/" + month + "/" + year;
        }


    }   
}
