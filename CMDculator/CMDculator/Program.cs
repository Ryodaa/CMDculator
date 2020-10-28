using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CMDculator
{
    class Program
    {
        static void Main(string[] args)
        {

                Console.WriteLine("Welcome to CMDculator");
                Console.WriteLine(" ");

            while (true)
            {

                Console.WriteLine("Possible operators are: + (plus), - (minus), * (multiply), / (divide), s (square root) and ^ (exponent)");
                Console.WriteLine(" ");
                Console.Write("Please enter the first number:");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Please enter the operator:");
                string oper = Console.ReadLine();

                if (oper == "s")
                {
                    Console.WriteLine("The square root of " + num1 + " is " + Math.Sqrt(num1));
                    Console.WriteLine(" ");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadLine();
                    continue;
                }

                Console.Write("Please enter the second number:");
                double num2 = Convert.ToDouble(Console.ReadLine());

                if (oper == "+" || oper == "-" || oper == "*" || oper == "/")
                {
                    Console.WriteLine("The result of " + num1 + " " + oper + " " + num2 + " is = " + BasicOp(num1, oper, num2));
                }
                else if (oper == "^")
                {
                    Console.WriteLine(num1 + " to the power of " + num2 + " is " + PowOp(num1, num2));
                }
                else
                {
                    Console.WriteLine("Operator currently not supported");
                }

                Console.WriteLine(" ");
                Console.WriteLine("Press any key to continue");
                Console.ReadLine();

            }
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

        static double PowOp(double num1, double num2)
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
