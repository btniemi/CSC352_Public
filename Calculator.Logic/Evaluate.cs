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

            //Read the postfix expression token by token
            //  If the token is an operand, push it onto the stack
            //  If the token is a binary operator,
            //      Pop the two topmost operands from the stack
            //      Apply the binary operator to the two operands
            //      Push the result back onto the stack
            //  Finally, the value of the whole postfix expression remains in the stack

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

        public static string EvaluateRPN_StepByStepInfix(string rpn)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Parser.ConvertToInfix(rpn));
            Stack<double> evalStack = new Stack<double>();
            string[] tokens = rpn.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);


            for(int i=0; i<tokens.Length; i++)
            {
                string token = tokens[i];
                if (isOperator(token))
                {
                    double y = evalStack.Pop();
                    double x = evalStack.Pop();
                    double z = 0;
                    if (token == "^")
                    {
                        z = Math.Pow(x, y);
                        sb.AppendLine($"Raise {x} to the {y} Power to get {z}");
                    }
                    else if (token == "+")
                    {
                        z = x + y;
                        sb.AppendLine($"Add {x} and {y} to get {z}");
                    }
                    else if (token == "-")
                    {
                        z = x - y;
                        sb.AppendLine($"Subtract {y} from {x} to get {z}");
                        
                    }
                    else if (token == "*")
                    {
                        z = x * y;
                        sb.AppendLine($"Multiply {x} by {y} to get {z}");
                        
                    }
                    else if (token == "/")
                    {
                        z = x / y;
                        sb.AppendLine($"Divide {x} by {y} to get {z}");
                        
                    }
                    else
                    {
                        throw new UnknownOperatorException($"Unknow operator {token} ");
                    }
                    evalStack.Push(z);
                    sb.AppendLine(Parser.ConvertToInfix(GenerateCurrentRPN(evalStack, tokens.Skip(i + 1))));
                }
                else
                {
                    evalStack.Push(double.Parse(token));
                }
            }
            //sb.AppendLine(evalStack.Pop().ToString());
            return sb.ToString();
        }

        /// <summary>
        /// regenerates the RPN that we were working on
        /// </summary>
        /// <param name="evalStack"></param>
        /// <param name="remainderRPN"></param>
        /// <returns></returns>
        private static string GenerateCurrentRPN(Stack<double> evalStack, IEnumerable<string> remainderRPN)
        {
            StringBuilder currentRPN = new StringBuilder();

            foreach(double current in evalStack.Reverse())
            {
                currentRPN.Append($"{current} ");
            }
            foreach(string current in remainderRPN)
            {
                currentRPN.Append($"{current} ");
            }
            return currentRPN.ToString().Trim();
        }

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
