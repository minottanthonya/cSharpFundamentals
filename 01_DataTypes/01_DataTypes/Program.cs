using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // VARIABLES    

            // 1. Data Type
            // 2. Variable Name
            // 3. Value associated to data type. 

            // 1      2       3
            int birthyear = 1990;

            int age;
            age = 28;


            // TYPES

            int i = 0;

            short sh = 32757;

            byte by = 255;

            string s = "hey!";

            char c = 'i';

            var s2 = @"a \tree"; // The @ symbol is used when about to call a reference tree as to specify a directory file on your machine. 

            bool b = false;

            long l = 7;

            decimal p = 99.99999999999999999999999999m; // have to use suffix 'm' to make this a working decimal. 

            double d = 7.80000000000000;

            float f = 10.8f; // must put 'f' explicit conversion afterwards. 

            decimal dd = 7.80m;

            int? ni = null; // When there is a ? afterwards it means the value can be null. When there is a ? afterwards it means the value can be null. 

            // Strings

            // 1      2            3
            string school = "Eleven Fifty";

            // 1. Data Type
            // 2. Variable Name
            // 3. Associated Value

            string firstName;
            string lastName;
            string occupation;
​
            firstName = "Charlie";
            lastName = "Brown";
            occupation = "Stuntman";
​
            string fullName = firstName + " " + lastName;
​
            Console.WriteLine(fullName);
​
            // String Interpolation
            Console.WriteLine("Name: {0}" + "\n" + "Occupation: {1}", fullName, occupation);

            // String Manipulation

            string first = "The cars we sell are ";
            string second = "BMW, Lexus, and Mercedes.";
            Console.WriteLine(first + second);
​
                //result: The cars we sell are BMW, Lexus, and Mercedes.

            //Composite Formatting 

            string firstName = "Nancy";
            string lastName = "St. Stacey";
            Console.WriteLine("Her name is {0} {1}.", firstName, lastName);
​
                //result: Her name is Nancy St. Stacey.

            // More String Interpolation

            string firstName = "Jenn";
            string lastName = "Williams";
            Console.WriteLine($"Her name is {firstName} {lastName}");
​
                //result: Her name is Jenn Williams.

            // Spliting up the string into an array

            Console.WriteLine("Type a word");
            string word = Console.ReadLine();
            char[] wordArray = word.ToCharArray();
            Array.Reverse(wordArray);
            string reversedWord = new string(wordArray);
            Console.WriteLine(reversedWord);

            // Integers

            //  1   2   3

            int i = 0;

            // 1. Data Type
            // 2. Variable Name
            // 3. Value Associated to Data type

            // Operators

            Console.WriteLine(5 + 2); //result = 7
            Console.WriteLine(10 - 6); //result = 4
            Console.WriteLine(2 * 3); //result = 6
            Console.WriteLine(10 / 2); //result = 5

            // Modulus 

            Console.WriteLine(10 % 2) //result = 0 (10/2 = 5 w/ remainder of 0)
            Console.WriteLine(10 % 9) //result = 1 (10/9 = 1 w/ remainder of 1)
            Console.WriteLine(16 % 3) //result = 1 (16/3 = 5 w/ remainder of 1)
            Console.WriteLine(19 % 5) //result = 4 (19/5 = 3 w/ remainder of 4)


        }
    }
}
