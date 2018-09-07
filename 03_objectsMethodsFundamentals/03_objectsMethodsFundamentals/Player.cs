using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_objectsMethodsFundamentals
{
    // Method Overloading

    // Overloading allows the programmer to define several methods with the same name, 
    // as long as they take a different set of parameters.


    class Player
    {
        //      1
        public void Attack()
        {
            Console.WriteLine("The player attacked for 5 points");
        }
        //      2
        public void Attack(int attackPoints)
        {
            Console.WriteLine("The player attacked for {0} points and has the sword", attackPoints);
        }
        //      3
        public void Attack(int attackPoints, string weaponName)
        {
            Console.WriteLine("The player attacked for {0} points and has a {1}", attackPoints, weaponName);
        }

        // 1. Base Method
        // 2. Overloaded method with 1 parameter
        // 3. Overloaded method with 2 parameters

    }
}
