using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Logic
{
    public class Parser
    {
        public static string ConvertToRPN(string equation)
        {
            Queue<string> outputQueue = new Queue<string>();
            Stack<string> operatorStack = new Stack<string>();

            string[] splitEquation = equation.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string token in splitEquation)
            {
                if (char.IsNumber(token.First()) || (token.Length > 1 && token.StartsWith("-")))
                {
                    outputQueue.Enqueue(token);
                }
                else if (isOperator(token))
                {
                    while
                        (
                            operatorStack.Any() &&
                            (
                                OperatorHasGreaterPrecidence(operatorStack.Peek(), token)
                                ||
                                (OperatorHasEqualPrecidence(operatorStack.Peek(), token) && TokenIsLeftAssociative(token))
                            ) &&
                            operatorStack.Peek() != "("
                        )
                    {
                        string op = operatorStack.Pop();
                        outputQueue.Enqueue(op);
                    }
                    operatorStack.Push(token);
                }
                else if (token.Equals("("))
                {
                    operatorStack.Push("(");
                }
                else if (token.Equals(")"))
                {
                    try
                    {
                        while (operatorStack.Peek() != "(")
                        {
                            outputQueue.Enqueue(operatorStack.Pop());
                        }
                        //Discard Left Paren"("
                        operatorStack.Pop();
                    }
                    catch (InvalidOperationException ex)
                    {
                        throw new InvalidOperationException("Unbalanced Parens!", ex);
                    }
                }
            }

            while (operatorStack.Any())
            {
                if (operatorStack.Peek() == "(")
                {
                    throw new InvalidOperationException("Unbalanced Parens!");
                }
                outputQueue.Enqueue(operatorStack.Pop());
            }


            StringBuilder sb = new StringBuilder();

            foreach (var outputElement in outputQueue)
            {
                sb.Append(outputElement);
                sb.Append(" ");
            }

            return sb.ToString().TrimEnd();
        }


        public static bool OperatorHasGreaterPrecidence(string v, string token)
        {
            bool hasGreaterPrecidence = false;

            if(v == "^")
            {
                if(token == "+" || token == "-" || token == "*" || token == "/")
                {
                    hasGreaterPrecidence = true;
                }
            }
            else if(v == "*" || v == "/")
            {
                if(token == "+" || token == "-")
                {
                    hasGreaterPrecidence = true;
                }
            }
            return hasGreaterPrecidence;
        }

        public static bool OperatorHasEqualPrecidence(string v, string token)
        {
            bool hasEqualPrecidence = false;

            if (v == token)
            {
                hasEqualPrecidence = true;
            }
            else if (v == "+" || v == "-")
            {
                if (token == "+" || token == "-")
                {
                    hasEqualPrecidence = true;
                }
            }
            else if (v == "*" || v == "/")
            {
                if (token == "*" || token == "/")
                {
                    hasEqualPrecidence = true;
                }
            }
            return hasEqualPrecidence;
        }


        public static bool TokenIsLeftAssociative(string token)
        {
            bool leftAssociative = true;
            if(token == "^")
            {
                leftAssociative = false;
            }
            return leftAssociative;
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


///* This implementation does not implement composite functions,functions with variable number of arguments, and unary operators. */

//while there are tokens to be read:
//    read a token.
//    if the token is a number, then:
//        push it to the output queue.
//    else if the token is a function then:       this is for sin and other functions
//        push it onto the operator stack 
//    else if the token is an operator then:
//        while ((there is an operator at the top of the operator stack)
//              and((the operator at the top of the operator stack has greater precedence)
//                  or(the operator at the top of the operator stack has equal precedence and the token is left associative))
//              and(the operator at the top of the operator stack is not a left parenthesis)):
//            pop operators from the operator stack onto the output queue.
//        push it onto the operator stack.
//    else if the token is a left parenthesis (i.e. "("), then:
//push it onto the operator stack.
//    else if the token is a right parenthesis (i.e. ")"), then:
//while the operator at the top of the operator stack is not a left parenthesis:

//    pop the operator from the operator stack onto the output queue.
//        /* If the stack runs out without finding a left parenthesis, then there are mismatched parentheses. */
//        if there is a left parenthesis at the top of the operator stack, then:

//    pop the operator from the operator stack and discard it
///* After while loop, if operator stack not null, pop everything to output queue */
//if there are no more tokens to read then:
//    while there are still operator tokens on the stack:
//        /* If the operator token on the top of the stack is a parenthesis, then there are mismatched parentheses. */
//pop the operator from the operator stack onto the output queue.
//exit.
