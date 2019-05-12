using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB8
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("DangLeGiaVu", "New York");
            Student student = new Student(person.getName,person.getAddress,"Math", 2000, 155.5);
            Staff staff = new Staff(person.getName, person.getAddress, "HUFLIT", 123.5);
            Console.WriteLine(person.toString);
            Console.WriteLine(student.toString);
            Console.WriteLine(staff.toString);
        }
    }
}
