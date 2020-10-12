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
            double x, y;  //change this to string and at the end change back to double? or try the !Double.TryParse thing?

            foreach(string token in splitRPN)
            {
                evalStack.Push(token);

                if (isOperator(token))
                {
                    y = evalStack.Pop();
                    x = evalStack.Pop();

                }

            }
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
