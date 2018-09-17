using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_arraysAndControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays!

            decimal[] bankBalance = new decimal[10];
            bankBalance[0] = 4500.0m;

            // Standard Array

            string[] food = new string[4];
            food[0] = "Macaroni";
            food[1] = "Pasta";
            food[2] = "Pizza";
            food[3] = "Popcorn";

            // Another example of an Array

            int[] integer2 = new int[5] { 10, 40, 50, 20, 40 };

            Console.WriteLine(integer2[4]);

            // LOOPS

            // Challenges

            for (int i = 500; i <= 1000; i++)
            {
                Console.WriteLine(i);
            }

            // Silver Challenge
            // Create a for loop that prints the numbers from 0-100 by 5's

            for (int x = 0; x <= 100; x+= 5)
            {
                Console.WriteLine(x);
            }

            //Gold

            for (int z = 1; z <= 100; z++)
            {
                if (z % 3 == 0 && z % 5 == 0) 
                {
                    Console.WriteLine("FizzBuzz");
                }

                else if (z % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (z % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(z);
                }
            }

            Console.ReadLine();
            // Dictionary 
            IDictionary<string, string> goldenGirls = new Dictionary<string, string>();
            goldenGirls.Add("Rose", "Sweet");
            goldenGirls.Add("Dorothy", "Sharp");
            goldenGirls.Add("Blanche", "Southern");
            goldenGirls.Add("Sophia", "Sassy");
            
            foreach (KeyValuePair<string, string> pair in goldenGirls)
            {
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            }

            Console.ReadLine();
            }
    }
}

// Examples

//   Array


//      1       2     3    4    5
//   string[] food = new string[4];
//          6
//      food[0] = "Macaroni";
//      food[1] = "Pasta";
//      food[2] = "Pizza";
//      food[3] = "Popcorn";

// 1. Declaring an array that will hold string values
// 2. Name of the array
// 3. Using keyword new to instantiate a new array
// 4. Will hold string values
// 5. The array will hold 4 different values
// 6. Putting values into the array.For the first example, we say the 0 index of this array will hold the value Macaroni.


//         While Loop

//          1
//         int number = 0;
//          2     3
//         while(number <= 100)
//          {
//                4
//              Console.WriteLine(number);
//              number = number + 5;
//          }
//          Console.ReadLine();

// 1. Declaring that number is going to be equal to 0
// 2. Declaring that this is a while loop
// 3. The condition that must be true for the loop to continue to run. "while this is true, continue the loop"
// 4. Indicating what will happen each loop.  We will print number to the console and add 5 to the index


//          For Loop

//           1
//          int number = 100;
//           2      3        4          5
//          for(int i = 0; i <= number; i++)
//             6
//            Console.WriteLine(i);
//            Console.ReadLine();

// 1. Declaring that number is equal to 100
// 2. Declaring that this is a for loop
// 3. Declaring that the for loop will start at 0
// 4. Declaring that as long as the index is less than number, continue with the loop
// 5. Add one to the index after each loop
// 6. Print each number to the console


//          For Each Loop

//            1
//          ArrayList nameList = new ArrayList();
//          nameList.Add("Paul O");
//              nameList.Add("Kenn P");
//              nameList.Add("Jenn A");
//            2        3          
//          foreach (string name in nameList)
//                  4
//              Console.WriteLine(name);
//              Console.ReadLine();

// 1. The array we built and will use a foreach loop to grab data
// 2. Declaring that this is a foreach loop
// 3. For each string in our array we will call it name
// 4. After each instance of the loop it will print name

// Note: you will need to bring in a using statement for ArrayList() to work 1. 
// Hover over ArrayList() 2. Press the CTRL key and the . key 3. Press Enter and it will bring in System.Collections


//         Example of a Dictionary 

//          1           2            3     4
//         IDictionary<int, string> dict = new Dictionary<int, string>();
//           5     6    7
//          dict.Add(1,"One");
//          dict.Add(2,"Two");
//          dict.Add(3,"Three");

// 1. Declaring that you are building a dictionary
// 2. The parameter types for your dictionary.A related int and string value
// 3. The name of your dictionary
// 4. Instantiation of a new dictionary
// 5. Accessing your dictionary by just typing the name
// 6. Using the.Add() function to begin adding data to your dictionary
// 7. Key/Value pairs you are adding to your dictionary