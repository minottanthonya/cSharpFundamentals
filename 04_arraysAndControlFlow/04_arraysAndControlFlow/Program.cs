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

            string[] food = new string[4];
            food[0] = "Macaroni";
            food[1] = "Pasta";
            food[2] = "Pizza";
            food[3] = "Popcorn";

            Console.WriteLine(food[1]);
            Console.ReadLine();
        }
    }
}


// Examples

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