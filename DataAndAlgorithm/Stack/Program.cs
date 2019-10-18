using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Bai 3.1
            mystack stack = new mystack(5);
            stack.push("dang");
            stack.push("dang");
            stack.push("dang");
            stack.push("le");
            stack.push("vu");

            string outitem = stack.pop();
            console.writeline(outitem);
            console.writeline(stack.peek());
            if (stack.isempty()) console.writeline("stack is empty");
            else console.writeline("stack is not empty");

            stack.clear();

            if (stack.isempty()) console.writeline("stack is empty");
            else console.writeline("stack is not empty");

            if (stack.isfull()) console.writeline("stack is full");
            else console.writeline("stack is not full");
            string x = "vu";
            if (stack.contains(x)) console.writeline("found x");
            else console.writeline("not found");
               */

            /* 3.2 */

            MyExpression exp = new MyExpression("a+b*(c^d-e)^(f+g*h)-i");
            string res = exp.infixToPostfix();
            Console.WriteLine(res);

        }
    }
}
