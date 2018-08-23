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
?
            firstName = "Charlie";
            lastName = "Brown";
            occupation = "Stuntman";
?
            string fullName = firstName + " " + lastName;
?
            Console.WriteLine(fullName);
?
            //String Interpolation
            Console.WriteLine("Name: {0}" + "\n" + "Occupation: {1}", fullName, occupation);
        }
    }
}
