using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace week9projectmath
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            int shapeSelection;
            double total;
            double two = 2;
            string inputString = "y";



            while (inputString == "y" || inputString == "Y")
            {
                WriteLine("please enter which shape you would like to determine the Area of:\n1.Square\n2.Rectangle\n3.Triangle");
                shapeSelection = Convert.ToInt32(ReadLine());
                if (shapeSelection == 1)
                {
                    WriteLine("please enter the the length of both sides");
                    num1 = Convert.ToDouble(ReadLine());
                    total = CalcArea(num1);
                    WriteLine($"{total}");


                }

                else if (shapeSelection == 2)
                {
                    WriteLine("please enter the length");
                    num1 = Convert.ToDouble(ReadLine());
                    WriteLine("Please enter the Width");
                    num2 = Convert.ToDouble(ReadLine());
                    total = CalCArea(num1, num2);
                    WriteLine($"The area of the rectangle is {total}");
                }

                else if (shapeSelection == 3)
                {
                    WriteLine("please enter the height of the triangle");
                    num1 = Convert.ToDouble(ReadLine());
                    WriteLine("please enter the base of the triangle");
                    num2 = Convert.ToDouble(ReadLine());
                    total = CalcArea(num1, num2, two);
                    WriteLine($"the area of the triangle is {total}");
                }

                else
                {
                    WriteLine("please enter which shape you would like to determine the Area of:\n1.Square\n2.Rectangle\n3.Triangle");
                    WriteLine();
                }


                WriteLine("Would you like to make another selection?\n y-yes\n n-no");
                inputString = ReadLine();
                
            }
            WriteLine("thank you come again");

            ReadKey();

        }//closes main
        static double CalcArea(double a)
        {
            double total = a * a;
            return total;
        }

        static double CalCArea( double a, double b)
        {
            double total = a * b;
            return total;
        }

        static double CalcArea(double a, double b, double c)
        {
            double total = (a * b) / c;
            return total;
        }
    }
}