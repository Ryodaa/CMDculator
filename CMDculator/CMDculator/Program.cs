using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CMDculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Welcome to CMDculator");
                Console.WriteLine(" ");

                while (true)
                {
                    Console.WriteLine("Possible operators are: + (plus), - (minus), * (multiply), / (divide), s (square root)");
                    Console.WriteLine("                        ^ (exponent), is% (x of y = %) and %of (% of x = y)");
                    Console.WriteLine(" ");
                    Console.Write("Please enter the first number:");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Please enter the operator:");
                    string oper = Console.ReadLine();

                    if (oper == "s") // Method to get the square root
                    {
                        Console.WriteLine("The square root of " + num1 + " is " + Math.Sqrt(num1));
                        Console.WriteLine(" ");
                        Console.WriteLine("Press any key to continue");
                        Console.ReadLine();
                        continue; // So the code will not prompt for num2 since num2 is redundant for the square root method
                    }

                    Console.Write("Please enter the second number:");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    if (oper == "+" || oper == "-" || oper == "*" || oper == "/") // Prints out results for +, -, * and / 
                    {
                        Console.WriteLine("The result of " + num1 + " " + oper + " " + num2 + " is = " + BasicOp(num1, oper, num2));
                    }
                    else if (oper == "^") // Prints out result for exponents
                    {
                        Console.WriteLine(num1 + " to the power of " + num2 + " is " + PowOp(num1, num2));
                    }
                    else if (oper == "is%") // Prints out result for x of y is percentage (gives percentage)
                    {
                        Console.WriteLine(num1 + " of " + num2 + " is = " + PercentOneOp(num1, num2) + "%");
                    } 
                    else if (oper == "%of") // Prints out result for percentage of x is y (gives value)
                    {
                        Console.WriteLine(num1 + "% of " + num2 + " is = " + PercentTwoOp(num1, num2));
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
            catch (Exception e)
            {
                Console.WriteLine(" ");
                Console.WriteLine(e);
                Console.ReadLine();

            }

            static double BasicOp(double num1, string oper, double num2) // Method for addition, subtraction, multiplication and division
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

            static double PowOp(double num1, double num2) // Method for exponents (power)
            {
                double resultPowOp = 1;
                for (double count = 1; count <= num2; count++)
                {
                    resultPowOp *= num1;
                }
                return resultPowOp;
            }

            static double PercentOneOp(double num1, double num2) // Method for percentages (ex: 5 of 10 are 50%)
            {

                double resultPercentOp = num1 * 100 / num2;
                return resultPercentOp;
            }

            static double PercentTwoOp(double num1, double num2) // Method for percentages (ex: 50% of 10 are 5)
            {
                double resultPercentOpTwo = num2 / 100 * num1;
                return resultPercentOpTwo;
            }
        } 
    }
}
