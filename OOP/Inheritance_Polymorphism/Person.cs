using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB8
{
    class Person
    {
        protected string name;
        protected string address;

        // Overloading constructor
        public Person(string name,string address)
        {
            this.name = name;
            this.address = address;
        }

        public string getName => name;
        public string getAddress => address;
        public string setAddress(string address) => this.address = address;

        public virtual string toString => "Person[name=" +name + ',' + "address=" + address +']';

    }
}
