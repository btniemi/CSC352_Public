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
            Stack<string> evalStack = new Stack<string>();
            string[] splitRPN = rpn.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string token in splitRPN)
            {
                evalStack.Push(token);

                if (isOperator(token))
                {
                    evalStack.Pop();
                    double y = Double.Parse(evalStack.Pop());
                    double x = Double.Parse(evalStack.Pop());
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
                    evalStack.Push(z.ToString());
                }
            }
            string finalValue = evalStack.Pop();
            return Double.Parse(finalValue);
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
            throw new NotSupportedException();
            // put into RPN and then call EvaluateRPN
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
