using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Created by Chicken_Coder
namespace ConsoleApp2
{
    class Author
    {
        // Declare member varriables
        private string name;
        private string email;
        private char gender;
        
        public Author(string name, string email, char gender)
        {
            this.name = name;
            this.email = email;
            if (gender == 'm' || gender == 'f')
                this.gender = gender;         
        }
        // Use Properties to Simple.
        public string getName => name;
        public string getEmail => email;     
        public char getGender => gender;
        public string setEmail(string email) => this.email = email;
        public string toString => "Author[name=" + name + ",email=" + email + ",gender=" + gender + "]";
    }
}
