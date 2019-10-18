using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class MyExpression
    {
        private string list;
        private Stack<char> opStack;

        public MyExpression(string list)
        {
            this.list = list;
        }

        public int TypeSwitch(char ch)
        {
            switch (ch)
            {
                case '+':
                case '-':
                    return 1;

                case '*':
                case '/':
                    return 2;

                case '^':
                    return 3;     
            }

            return -1;
        }

        public string infixToPostfix()
        {
            string result = "";
            opStack = new Stack<char>();

            for (int i = 0; i < list.Length; i++)
            {
                char c = list[i];
                if (char.IsLetterOrDigit(c))
                    result += c;
                else if (c == '(')
                    opStack.Push(c);
                else if (c == ')')
                {
                    while (opStack.Count > 0 && opStack.Peek() != '(')                   
                        result += opStack.Pop();
                    if (opStack.Count > 0 && opStack.Peek() != '(')
                        return "Invalid Expression";
                    else
                        opStack.Pop();
                }
                else
                {
                    while (opStack.Count > 0 && TypeSwitch(c) <= TypeSwitch(opStack.Peek()))
                        result += opStack.Pop();
                    opStack.Push(c);

                }           
            }
            while (opStack.Count > 0)
                result += opStack.Pop();
            return result;
        }




    }
}
