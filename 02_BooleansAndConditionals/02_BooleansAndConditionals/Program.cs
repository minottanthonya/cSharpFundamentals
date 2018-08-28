using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BooleansAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            // Visual Representation 

            //   1        2         3
            bool isEmployed = false;

            // 1. Data type

            // 2. Declaration with a variable name

            // 3. Initialization with value associated to data type



            // Boolean Logic: If

            //1
            int value = 5;
            //2
            if (value < 10)
            {
                //3
                Console.WriteLine("Yes, the expression is true");



             // If, Else If, and Else Statements

             int value = 100 / 2;

                if (value == 50)
                {
                    Console.WriteLine(true);
                }
                Console.ReadLine();

                Console.WriteLine("Enter a number");
                int UserNumber = int.Parse(Console.ReadLine());
​
            if (UserNumber == 1)
                {
                    Console.WriteLine("Your number is 1");
                }
                else if (UserNumber == 2)
                {
                    Console.WriteLine("Your number is 2");
                }
                else if (UserNumber == 3)
                {
                    Console.WriteLine("Your number is 3");
                }
                else
                {
                    Console.WriteLine("Wrong Number");
                }

            // Switch Statments

                Console.WriteLine("What's your name?"); //1
                string inputName = Console.ReadLine().ToLower(); //2
                                                                 //3
                switch (inputName)
                   {
                    case "fred":
                        Console.WriteLine("Hey Fred, let's go golfing.");
                        break;
                    case "karl":
                        Console.WriteLine("Let's hang.");
                        break;
                    case "john":
                        Console.WriteLine("Sorry, I'm busy right now.");
                        break;
                    default:
                        Console.WriteLine("Hey " + inputName + ", can I call you back in a minute?");
                        break;}


            }
        }
    }
}
