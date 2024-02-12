using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace labsheet_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //q1
            int myAge = 21;
            Console.WriteLine(myAge);

            decimal income = 100000m;
            Console.WriteLine(income);

            float temp_c = 23.3f;
            Console.WriteLine(temp_c);

            float temp_k = 34.4f;
            Console.WriteLine(temp_k);

            string name = "Vimal Raj";
            Console.WriteLine(name);
            Console.WriteLine("\n");
            //q2
            //q3
            double x = 3.0, y = 2.0;
            int a = 10, b = 2;
            Console.WriteLine(a);
            Console.WriteLine(x+a);
            Console.WriteLine(a/b);
            Console.WriteLine(y/x);
            Console.WriteLine(y%b);
            Console.WriteLine((a+b)/(b%a));
            Console.WriteLine(9.0 / 5.0 * (a - x));
            Console.WriteLine(x + y - x * y % x);
            Console.WriteLine(57 % 50 / 25);
            Console.WriteLine("\n");

            //q4
            //even or odd
            Console.WriteLine("enter a number: ");
            int z =Convert.ToInt32(Console.ReadLine());
            if (x%2==0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }

            //positive or negative
            Console.WriteLine("Enter a number: ");
            int q = Convert.ToInt32(Console.ReadLine());
            if(q>0)
            {
                Console.WriteLine("POSITIVE");
            }
            else if(q<0)
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("INVAILD NUMBER");
            }

            //multiple of 6 or not
            Console.WriteLine("Enter a number: ");
            int w = Convert.ToInt32(Console.ReadLine());
            if (w % 6 == 0)
            {
                Console.WriteLine(w + " is a multiple of 6");
            }
            else
            {
                Console.WriteLine(w + " is not a multiple of 6");
            }

            //multiple of 100 or not
            Console.WriteLine("Enter a number: ");
            int t = Convert.ToInt32(Console.ReadLine());
            if (t % 100 == 0)
            {
                Console.WriteLine(t + " is a multiple of 100");
            }
            else
            {
                Console.WriteLine(t + " is not a multile of 100");
            }

            //q5
            /*Write a C# program which attempts to identify the quadrant of the input (x, y) coordinates. If the
              input coordinates happen to be on either X-axis or Y-axis, the program will display “I don’t know.”  */

            Console.WriteLine("Enter X: ");
            int X= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Y: ");
            int Y = Convert.ToInt32(Console.ReadLine());
            if (X > 0)
            {
                if (Y > 0)
                {
                    Console.WriteLine("Q1");
                }
                else if (Y < 0)
                {
                    Console.WriteLine("Q4");
                }
                else
                {
                    Console.WriteLine("I don't no");
                }
            }
            else
            {
                if(Y > 0)
                {
                    Console.WriteLine("Q2");
                }
                else if(Y < 0)
                {
                    Console.WriteLine("Q3");
                }
                else
                {
                    Console.WriteLine("I don't no");
                }
            }

            //q6
            /*A cellular phone company has a promotion plan for its customers. The air time fee is calculated as
            follows
                • Each of the first two minutes costs 5 paise (per minute)
                • Each of the remaining minutes costs 2 paise (per minute)
             Take the number of minutes from the user, and computes the total air time fee.
            */
            Console.WriteLine("Enter the number of minutes: ");
            int min = Convert.ToInt32(Console.ReadLine());
            double TotalFee;
            if (min <= 2)
            {
                TotalFee = min * 5;
            }
            else
            {
                TotalFee = 5 * 2 + (min - 2) * 2;
            }
            Console.WriteLine(TotalFee);

            //q7
            /*Write a BMI calculator program which will find your body status. Use the following rule
            BMI = Weight(in kg)/ height*height (in meter)
            */
            Console.WriteLine("Enter the weight in kg: ");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height in m");
            double height = double.Parse(Console.ReadLine());
            double BMI = weight / height * height;
            Console.WriteLine("Your BMI is"+ BMI);
            if(BMI < 18.5)
            {
                Console.WriteLine("Underweight");
            }
            else if (18.5<=BMI && BMI <25){
                Console.WriteLine("Normal");
            }
            else if(25<= BMI && BMI < 30 ){
                Console.WriteLine("Overweight");
            }
            else
            {
                Console.WriteLine("Obese");
            }

            //Q8

            Console.WriteLine("Enter a number: ");
            float num = float.Parse(Console.ReadLine());
            int number = Convert.ToInt32(Math.Round(num));
            if (number == num)
            {
                Console.WriteLine("The given input is integer");
            }
            else
            {
                Console.WriteLine("The given number id not a intger");
            }

            //Q9

            Console.WriteLine("Enter a UPPER CASE letter: ");
            char ltr = char.Parse(Console.ReadLine());
            switch (ltr)
            {
                case 'A':
                case 'B':
                case 'C':
                    Console.WriteLine("2");
                    break;

                case 'D':
                case 'E':
                case 'F':
                    Console.WriteLine("3");
                    break;

                case 'G':
                case 'H':
                case 'I':
                    Console.WriteLine("4");
                    break;

                case 'J':
                case 'K':
                case 'L':
                    Console.WriteLine("5");
                    break;

                case 'M':
                case 'N':
                case 'O':
                    Console.WriteLine("6");
                    break;

                case 'P':
                case 'Q':
                case 'R':
                case 'S':
                    Console.WriteLine("7");
                    break;

                case 'T':
                case 'U':
                case 'V':
                    Console.WriteLine("8");
                    break;

                case 'W':
                case 'X':
                case 'Y':
                case 'Z':
                    Console.WriteLine("9");
                    break;

                default:
                    Console.WriteLine("Given input is not uppercase !");
                    break;
            }

            //Q10

            Console.WriteLine("Choose the Shipping Type (Regular/Express)");
            string Type = Console.ReadLine();
            Console.WriteLine("How much kg: ");
            float kg = float.Parse(Console.ReadLine());
            int gram = Convert.ToInt32(kg*1000);
            int total_price;
            if (Type == "Regular " || Type == "regular")
            {
                if(gram <= 2000)
                {
                    total_price = Convert.ToInt32(gram * 0.50);
                }
                else if(gram > 2000)
                {
                    total_price = Convert.ToInt32(2000 * 0.50 + (gram - 2000) * 0.75);
                }
            }
            else if ( Type == "Express" || Type == "express")
            {
                if (gram <= 2000)
                {
                    total_price = Convert.ToInt32((gram * 0.50)+50);
                }
                else if (gram > 2000)
                {
                    total_price = Convert.ToInt32((2000 * 0.50 + (gram - 2000) * 0.75)+50);
                }
            }
            else
            {
                Console.WriteLine("Invaild Inout");
            }
            Console.Read();
        }
    }
}
