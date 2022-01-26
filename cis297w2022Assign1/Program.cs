using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis297w2022Assign1
{
    /// <summary>
    /// This program implements some arithmetic functions as a calculator
    /// </summary>
    /// <Student> Shahriar Sagor </Student>
    /// <Class>CIS297</Class>
    /// <Semester> Winter 2022 </Semester>
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();

            }
        }

        /// <summary>
        /// MainMenu will display and allow user to choose an option from the lists. Based on the option user choose the program will execute.
        /// </summary>
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Return a string without the Whitespaces");
            Console.WriteLine("2) Reverse a string");
            Console.WriteLine("3) Display the quotient and the remainder");
            Console.WriteLine("4) Find the logarithm of a specified number to base 10");
            Console.WriteLine("5) Find the logarithm of a specified number to a specified base");
            Console.WriteLine("6) Display the minimum and maximum of the two numbers");
            Console.WriteLine("7) Find the specified number to the specified power");
            Console.WriteLine("8) Find the roots of a quadratic equation");
            Console.WriteLine("9) Find the square root of the given number");
            Console.WriteLine("10) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1"://1.	Return a string without the Whitespaces
                    RemoveWhitespace();
                    return true;

                case "2"://2.	Reverse a string
                    ReverseString();
                    return true;

                case "3"://3.	Display the quotient and the remainder
                    QuotientRemainder();
                    return true;

                case "4"://4.	Find the logarithm of a specified number to base 10
                    Logarithm();
                    return true;

                case "5"://5.	Find the logarithm of a specified number to a specified base
                    LogarithmSB();
                    return true;

                case "6"://6.	Display the minimum and maximum of the two numbers
                    MinMax();
                    return true;

                case "7"://7.	Find the specified number to the specified power
                    sPower();
                    return true;

                case "8"://8.	Find the roots of a quadratic equation
                    QuadraticRoot();
                    return true;

                case "9": //9. Find the square root of the given number
                    SquareRoot();
                    return true;

                case "10": //10. Exit
                    return false;

                default:
                    return true;
            }
        }

        /// <summary>
        /// This method captures user input as a string
        /// </summary>
        /// <returns>The <see cref="System.String"/returns>
        private static string CaptureInput()
        {
            Console.Write("Enter the string you want to modify: ");
            return Console.ReadLine();
        }

        /// <summary>
        /// This method	returns a string without the Whitespaces
        /// </summary>

        private static void RemoveWhitespace()
        {
            Console.Clear();
            Console.WriteLine("Remove Whitespace");

            DisplayResult(CaptureInput().Replace(" ", ""));

        }


        /// <summary>
        /// This method reverse a string
        /// </summary>
        private static void ReverseString()
        {
            Console.Clear();
            Console.WriteLine("Reverse String");

            char[] charArray = CaptureInput().ToCharArray();
            Array.Reverse(charArray);
            DisplayResult(String.Concat(charArray));

        }

        /// <summary>
        /// This method display the quotient and the remainder
        /// </summary>
        private static void QuotientRemainder()
        {
            Console.Clear();
            Console.WriteLine("Display the quotient and the remainder");

            Console.Write("Enter the divident number: ");
            int divident = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the divisor number: ");
            int divisor = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(divident + " divided by " + divisor + " results in " + (divident / divisor) + " as the qoutient and " + (divident % divisor) + " as the remainder.");

            Console.Write("\r\nPress Enter to return to Main Menu");
            Console.ReadLine();
        }

        /// <summary>
        /// This method is to find the logarithm of a specified number to base 10
        /// </summary>
        private static void Logarithm()
        {
            Console.Clear();
            Console.WriteLine("Find the logarithm of a specified number to base 10");

            Console.Write("Enter the number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Log(" + num1 + ") to the base 10 is " + Math.Log10(num1));

            Console.Write("\r\nPress Enter to return to Main Menu");
            Console.ReadLine();


        }


        /// <summary>
        /// This method is to find the logarithm of a specified number to a specified base
        /// </summary>
        private static void LogarithmSB()
        {
            Console.Clear();
            Console.WriteLine("Find the logarithm of a specified number to a specified base");

            Console.Write("Enter the number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the base: ");
            int base1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Log(" + num1 + ") to the base " + base1 + " is " + Math.Log(num1, base1));

            Console.Write("\r\nPress Enter to return to Main Menu");
            Console.ReadLine();

        }

        /// <summary>
        /// This method display the minimum and maximum of the two numbers
        /// </summary>
        private static void MinMax()
        {
            Console.Clear();
            Console.WriteLine("Display the minimum and maximum of the two numbers");
            Console.Write("Enter the first numbers: ");
            double firstNum = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second numbers: ");
            double SecondNum = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Maximum of " + firstNum + " and " + SecondNum + " is " + Math.Max(firstNum, SecondNum));
            Console.WriteLine("Minimum of " + firstNum + " and " + SecondNum + " is " + Math.Min(firstNum, SecondNum));

            Console.Write("\r\nPress Enter to return to Main Menu");
            Console.ReadLine();

        }

        /// <summary>
        ///This method is to find the specified number to the specified power
        /// </summary>
        private static void sPower()
        {
            Console.Clear();
            Console.WriteLine("Find the specified number to the specified power");

            Console.Write("Enter the number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the power: ");
            int power = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 + " to the power " + power + " is " + Math.Pow(num1, power));

            Console.Write("\r\nPress Enter to return to Main Menu");
            Console.ReadLine();

        }

        /// <summary>
        /// This method is to find the roots of a quadratic equation
        /// </summary>
        private static void QuadraticRoot()
        {
            int numA, numB, numC;
            double d, X1, X2;

            Console.Clear();
            Console.WriteLine("Find the roots of a quadratic equation");

            Console.Write("Enter the coefficient number a: ");
            numA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the coefficient number b: ");
            numB = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the constant c: ");
            numC = Convert.ToInt32(Console.ReadLine());

            d = numB * numB - 4 * numA * numC;


            if (d == 0)
            {
                Console.Write("Both roots are equal.\n");
                X1 = -numB / (2.0 * numA);
                X2 = X1;
                Console.Write("First  Root Root1= {0}\n", X1);
                Console.Write("Second Root Root2= {0}\n", X2);
            }
            else if (d > 0)
            {
                X1 = (-numB + Math.Sqrt(d)) / (2 * numA);
                X2 = (-numB - Math.Sqrt(d)) / (2 * numA);

                Console.Write("Root X1= {0}\n", X1);
                Console.Write("Root X2= {0}\n", X2);
            }
            else
            {
                Console.Write("Root are imeainary; \nNo Solution. \n\n");
            }
            Console.Write("\r\nPress Enter to return to Main Menu");
            Console.ReadLine();
        }

        /// <summary>
        /// This method displays the result as a modified string
        /// </summary>
        /// <param name="message">The <see cref="System.String"/> message to display.</param>
        private static void DisplayResult(string message)
        {
            Console.WriteLine($"\r\nYour modified string is: {message}");
            Console.Write("\r\nPress Enter to return to Main Menu");
            Console.ReadLine();
        }

        /// <summary>
        /// Sqrt-Square Root. This function returns the square root of the given number.
        /// </summary>

        private static void SquareRoot()
        {
            Console.Clear();
            Console.WriteLine("Find the square root of the given number");
            Console.Write("Enter the number: ");
            double number7 = double.Parse(Console.ReadLine());
            Console.WriteLine("Square root of {0} is {1}.", number7, Math.Sqrt(number7));
            Console.Write("\r\nPress Enter to return to Main Menu");
            Console.ReadLine();
        }
    }
}
