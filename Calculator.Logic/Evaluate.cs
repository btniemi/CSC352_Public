using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Logic
{
    public class Evaluate
    {
        public static double EvaluateRPN(string rpn)
        {
            Stack<double> evalStack = new Stack<double>();
            string[] splitRPN = rpn.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string token in splitRPN)
            {

                if (isOperator(token))
                {
                    double y = evalStack.Pop();
                    double x = evalStack.Pop();
                    double z = 0;
                    if (token == "^")
                    {
                        z = Math.Pow(x, y);
                    }
                    if (token == "+")
                    {
                        z = x + y;
                    }
                    if (token == "-")
                    {
                        z = x - y;
                    }
                    if (token == "*")
                    {
                        z = x * y;
                    }
                    if (token == "/")
                    {
                        z = x / y;
                    }
                    evalStack.Push(z);
                }
                else
                {
                    evalStack.Push(double.Parse(token));
                }
            }
            return evalStack.Pop();
        }

        //Read the postfix expression token by token
        //  If the token is an operand, push it onto the stack
        //  If the token is a binary operator,
        //      Pop the two topmost operands from the stack
        //      Apply the binary operator to the two operands
        //      Push the result back onto the stack
        //  Finally, the value of the whole postfix expression remains in the stack

        public static double EvaluateInfix(string infix)
        {
            string conversion = Parser.ConvertToRPN(infix);
            double answer = EvaluateRPN(conversion);
            return answer;
        }

        private static bool isOperator(string token)
        {
            switch (token)
            {
                case "+":
                case "-":
                case "*":
                case "/":
                case "^":
                    return true;
                default:
                    return false;
            }
        }


    }
}
