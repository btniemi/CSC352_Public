using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreatePhoneNumber
{
    class Logic
    {
        internal static string TranslateToPhoneNumber(int[] numbers)
        {
            // Want (XXX) XXX-XXXX below solution is using a queue
            //System.Collections.Generic.Queue<string> queue = new Queue<string>();

            //queue.Enqueue("(");
            //for (int i = 0; i < 3; i++)
            //{
            //    queue.Enqueue(numbers[i].ToString());
            //}
            //queue.Enqueue(") ");
            //for(int i = 3; i < 6; i++)
            //{
            //    queue.Enqueue(numbers[i].ToString());
            //}
            //queue.Enqueue("-");
            //for(int i= 6; i<10; i++)
            //{
            //    queue.Enqueue(numbers[i].ToString());
            //}

            //StringBuilder sb = new StringBuilder();

            //while(queue.Count != 0)
            //{
            //    sb.Append(queue.Dequeue());
            //}

            //return sb.ToString();


            //string interpulation
            return $"({numbers[0]}{numbers[1]}{numbers[2]}) {numbers[3]}{numbers[4]}{numbers[5]}-{numbers[6]}{numbers[7]}{numbers[8]}{numbers[9]}";



        }
    }
}
