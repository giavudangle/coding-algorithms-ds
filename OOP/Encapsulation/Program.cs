using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region PhanSo
            /*PHANSO*/
            //PhanSo ps = new PhanSo();
            //PhanSo p = new PhanSo(3, 5);
            //ps.Nhap();
            //ps.In();
            //PhanSo sum=ps.Cong(p);
            //Console.Write(sum.In());
            //PhanSo minus = ps.Tru(p);
            //Console.Write(minus.In());
            //PhanSo mul = ps.Nhan(p);
            //Console.Write(mul.In());
            //PhanSo div = ps.Chia(p);
            //Console.Write(div.In());
            #endregion
            #region Point2D
            //Point2D p1 = new Point2D();
            //Point2D p2 = new Point2D(3, 4);
            //Point2D p3 = new Point2D(p2);
            //Point2D res = new Point2D();
            ////p1.Input();
            ////Console.WriteLine(p1.TOString());
            ////p1.Move(5, 5);
            ////Console.Write(p1.TOString());
            ////bool temp= p1.IsOrigin(0,0);
            ////Console.Write(temp);
            ////Console.Write(p1.Distance(p2));
            //Console.Write(Point2D.Distance(p1,p2));
            #endregion
            #region Triangle
            //Point2D p1 = new Point2D(1,1);
            //Point2D p2 = new Point2D(-1,5);
            //Point2D p3 = new Point2D(3,2);

            //double d1 = Point2D.Distance(p1, p2);
            //double d2 = Point2D.Distance(p1, p3);
            //double d3 = Point2D.Distance(p2, p3);

            ////Console.Write(Triangle.Perimeter(d1, d2, d3));
            //double halfPerimeter=(Triangle.Perimeter(d1, d2, d3)*1.0)/2;
            //Console.Write(Triangle.Area(halfPerimeter, d1, d2, d3));

            #endregion
            #region Date
            //Date date = new Date(30, 12, 2000);
            //Console.WriteLine(date.getDay);
            //Console.WriteLine(date.getMonth);
            //Console.WriteLine(date.getYear);
            //date.setDay(22);
            //date.setMonth(12);
            //date.setYear(2000);
            //date.setDate(22,12,1995);
            #endregion
            #region Author
            //Author author = new Author("GiaVu", "medusa666@gmail.com", 'f');
            //Console.WriteLine(author.getName);
            //Console.WriteLine(author.getEmail);
            //Console.WriteLine(author.getGender);
            //Console.Write(author.toString);

            #endregion
            #region Book
            Author author = new Author("DangLeGiaVu", "medusa666@gmail.com", 'f');
            Book book = new Book("Harry Potter", author, 5000.275);
            Book book1 = new Book("Harry Potter", author, 1230,2);
            Console.Write(book.toString);
            Console.Write(book1.toString);
            #endregion
        }
    }
}
