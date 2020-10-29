using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CMDculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Welcome to CMDculator by Ryodaa");
                Console.WriteLine(" ");

                while (true)
                {
                    Console.WriteLine("Possible operators are: + (plus),            - (minus),  ");
                    Console.WriteLine("                        * (multiply),        / (divide), ");
                    Console.WriteLine("                        ^ (exponent),        sq (square root) ");
                    Console.WriteLine("                        is% (x of y = %)     %of (% of x = y)");
                    Console.WriteLine(" ");
                    Console.WriteLine("Please enter your equation (ex: \"3 + 4\" or \"20 %of 100\"). Spaces are required!");
                    Char spaceChar = ' '; // Char defined for split function which is "space"
                    string input = Console.ReadLine(); // user input is being saved in variable "input"
                    string[] inputArray = input.Split(spaceChar); // Creates an array and sets it equal to the user input, applies split function to the user input and splits it by "spaces"
                    double num1 = Convert.ToDouble(inputArray[0]); // Converts array position 0 from a string to a double and puts it into a unique variable so the program can use it for the methods
                    string oper = inputArray[1]; // Since array position 1 is the operators and therefore was always supposed to be a string, there is no need for conversion as the array is already a string

                    if (oper == "sq") // Method to get the square root
                    {
                        Console.WriteLine("The square root of " + num1 + " is " + Math.Sqrt(num1));
                        Console.WriteLine(" ");
                        Console.WriteLine("Press any key to continue");
                        Console.ReadLine();
                        continue; // So the code will not prompt for num2 since num2 is redundant for the square root method
                    }

                    double num2 = Convert.ToDouble(inputArray[2]); // Same thing as array position 0

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
            catch (FormatException)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Format error! Correct format is: \" number *space* operator *space* number (ex: 1 + 1) \"");
                Console.ReadLine();
                return;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Format error! Correct format is: \" number *space* operator *space* number (ex: 1 + 1) \"");
                Console.ReadLine();
                return;
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
