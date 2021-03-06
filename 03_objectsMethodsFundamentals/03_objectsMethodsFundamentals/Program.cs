﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_objectsMethodsFundamentals
{
    // Defining a Class

    //    1      2     3
        public class Company
    {
        //     4
    }

    // 1. Access Modifier of class defined
    // 2. Declaring you are making a class
    // 3. Name of Class
    // 4. Body of Class


    // Visualizing properties

    public class House
    {
        //       1      2      3           4
                public int squarefeet { get; set; }
    }

    // 1. Access Modifier
    // 2. Property DataType
    // 3. Name of Property
    // 4. Accessor

    // Accessors are the second half of the syntax used when writing a property. It looks like this { get; set; }.


    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating the objects
            Donut dougDonut = new Donut();
            Donut chrisDonut = new Donut();
            Donut nickDonut = new Donut();

            //Setting values to properties of objects
            dougDonut.Filling = "cherry";
            dougDonut.Price = 3;
            dougDonut.Type = "normal";
            dougDonut.IsSpecial = true;

            chrisDonut.Filling = "none";
            chrisDonut.Price = 2;
            chrisDonut.Type = "small";
            chrisDonut.IsSpecial = false;

            nickDonut.Filling = "chocolate";
            nickDonut.Price = 3;
            nickDonut.Type = "normal";
            nickDonut.IsSpecial = true;

            // Console.WriteLine(nickDonut.Filling);

            // Challenges

            Hotel tonyHotel = new Hotel();

            tonyHotel.RoomNumber = "T20";
            tonyHotel.IsAvailable = false;
            tonyHotel.NumBeds = 2;

            // Silver Challenge

            // tonyHotel.PrintRoom();

            // Gold Challenge

            tonyHotel.IsRoomAvailable();

            // Methods 

            // Example of a method

            int Multiply(int numOne, int numTwo)
            {
                return numOne * numTwo;
            }
            
            //Console.WriteLine(Multiply(5, 2));


            // Example of Method Overloading

            Player newPlayer = new Player();

            newPlayer.Attack();
            newPlayer.Attack(10);
            newPlayer.Attack(6, "Greatsword");

            // Constructor Section

            Student carrStudent = new Student("Carr");
            
            Student caliStudent = new Student("Carr", "O'Connor");
            
            Student carolineStudent = new Student("Caroline", "O'Connor", 8);
            
            Student chrisStudent = new Student("Chris", "Weiper", 5, 11);
            
            Console.WriteLine(chrisStudent.FirstName + ": " + chrisStudent.Age);

            // Access Modifiers

            // There are five main modifiers. 

            //    Keyword                  Applicable To          Meaning
            // 1. public -                 Class, Member          No Restrictions.
            // 2. protected -              Member                 Limited to class and derived class. 
            // 3. private -                Member                 Limited to class. 
            // 4. internal -               Class, Member          Limited to current assembly. 
            // 5. protected internal -     Member                 Limted to current assembly and derived types. 


            //This read line will read all the console writelines for the entire program. 

            Console.ReadLine();
        }
    }
}
