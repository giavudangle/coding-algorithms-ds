using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Book
    {
        // Declare member varriables
        private string name;
        private Author author;
        private double price;
        private int qty = 0;

        public Book(string name,Author author,double price)
        {
            this.name = name;
            this.author = author;
            this.price = price;
        }

        public Book(string name, Author author,double price,int qty)
        {
            this.name = name;
            this.author = author;
            this.price = price;
            this.qty = qty;
        }
        // Use properties

        public string getName => name;
        public Author getAuthor => author;
        public double getPrice => price;
        public double setPrice(double price) => this.price = price;
        public int getQty => qty;
        public int setQty(int qty) => this.qty = qty;
        public string toString => "Book[name=" + name + "," + author.toString + ",price=" + price + ",qty=" + qty + "]";

    }
}
