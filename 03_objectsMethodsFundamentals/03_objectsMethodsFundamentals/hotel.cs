using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_objectsMethodsFundamentals
{
    class hotel
    {
        // Properties

        public string RoomNumber { get; set; }
        public bool IsAvailable { get; set; }
        public int NumBeds { get; set; }
        
        // Silver Challenge

        public void PrintRoom()
        {
            Console.WriteLine("Your room number is " + this.RoomNumber);
            Console.ReadLine();
        }

        // Gold Challenge

        public hotel IsRoomAvailable()
        {
            if(this.IsAvailable)
            {
                Console.WriteLine("Yes, room " + this.RoomNumber + " is available. Would you like to book it for tonight?");
                this.IsAvailable = false;
            } else
            {
                Console.WriteLine("I;m sorry, but room " + this.RoomNumber + " is not available tonight. Would you like to try a different room?");
            }
            return this;
        }


    }
}
