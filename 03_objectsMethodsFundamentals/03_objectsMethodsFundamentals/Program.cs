using System;
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
            Console.ReadLine();

        }
    }
}
