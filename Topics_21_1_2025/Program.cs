using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topics_21_1_2025
{
    internal class Program
    {
        class Hotel
        {
            public int RoomNumber
            { // property
                set; get;
            }  // proerty  encapculation
               // 

            public Hotel(int n) // constructor      initila property   method 
            {
                RoomNumber = n;
            }

            ~Hotel()
            {
                Console.WriteLine("finish");
            }

        }

        static void Main(string[] args)
        {

            Hotel h = new Hotel(3);
            h.RoomNumber = 10;
            Console.WriteLine(h.RoomNumber);
            Console.WriteLine(h.RoomNumber);
            Hotel h2 = new Hotel(3);
            Console.WriteLine(h2.RoomNumber);

        }
    }
}
