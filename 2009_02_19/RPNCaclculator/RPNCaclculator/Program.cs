using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace RPNCaclculator
{
    class Program
    {
        static char[] operands = { '+', '-', '*', '/' };
        static void Main(string[] args)
        {
            Stack operatorStack = new Stack();

            string input;
            input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (!IsOperand(input[i]))
                    operatorStack.Push(input[i]);
                else
                {
                    while (operatorStack.Count > 0)
                    {
                        operatorStack.Pop();
                    }
                }
            }
        }

        public static bool IsOperand(char c)
        {
            for (int i = 0; i < operands.Length; i++)
            {
                if (operands[i] == c)
                    return true;
            }
            return false;
        }
    }
}
