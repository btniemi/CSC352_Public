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
            sb.Append(Parser.ConvertToInfix(rpn));
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
                        sb.Append($"Raise {x} to the {y} Power to get {z}");
                        sb.AppendLine(Parser.ConvertToInfix(GenerateCurrentRPN(evalStack, tokens.Skip(i + 1))));
                    }
                    if (token == "+")
                    {
                        z = x + y;
                        sb.Append($"Add {x} and {y} to get {z}");
                        sb.AppendLine(Parser.ConvertToInfix(GenerateCurrentRPN(evalStack, tokens.Skip(i + 1))));
                    }
                    if (token == "-")
                    {
                        z = x - y;
                        sb.Append($"Subtract {y} from {x} to get {z}");
                        sb.AppendLine(Parser.ConvertToInfix(GenerateCurrentRPN(evalStack, tokens.Skip(i + 1))));
                    }
                    if (token == "*")
                    {
                        z = x * y;
                        sb.Append($"Multiply {x} by {y} to get {z}");
                        sb.AppendLine(Parser.ConvertToInfix(GenerateCurrentRPN(evalStack, tokens.Skip(i + 1))));
                    }
                    if (token == "/")
                    {
                        z = x / y;
                        sb.Append($"Divide {x} by {y} to get {z}");
                        sb.AppendLine(Parser.ConvertToInfix(GenerateCurrentRPN(evalStack, tokens.Skip(i+ 1))));
                    }
                    evalStack.Push(z);
                }
                else
                {
                    evalStack.Push(double.Parse(token));
                }
            }
            sb.Append(evalStack.Pop());
            return sb.ToString();
        }

        private static string GenerateCurrentRPN(Stack<double> evalStack, IEnumerable<string> enumerable)
        {
            StringBuilder currentRPN = new StringBuilder();

            foreach(var current in evalStack)
            {
                currentRPN.Append($"{current} ");
            }
            foreach(var current in enumerable)
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
