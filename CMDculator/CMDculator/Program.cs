﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMDculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the operator:");
            string oper = Console.ReadLine();
            Console.WriteLine("Please enter the second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (oper == "+" || oper == "-" || oper == "*" || oper == "/")
            {
                Console.WriteLine("The result of " + num1 + " " + oper + " " + num2 + " is = " + BasicOp(num1, oper, num2));
            }
            else if (oper == "^")
            {
                Console.WriteLine(powOp(num1, num2));
            }
            else
            {
                Console.WriteLine("Operator currently not supported");
            }

            Console.ReadLine();
        }

        static double BasicOp(double num1, string oper, double num2)
        {
            double resultBasicOp = 0;

            if (oper == "+")
            {
                resultBasicOp = num1 + num2;
            }
            else if (oper == "-")
            {
                resultBasicOp = num1 - num2;
            }
            else if (oper == "*")
            {
                resultBasicOp = num1 * num2;
            }
            else if (oper == "/")
            {
                resultBasicOp = num1 / num2;
            }
            return resultBasicOp;
        }

        static double powOp(double num1, double num2)
        {
            double resultPowOp = 1;

            for (double count = 1; count <= num2; count++) 
            {
                resultPowOp = resultPowOp * num1;
            }

            return resultPowOp;
        }
    }
}
