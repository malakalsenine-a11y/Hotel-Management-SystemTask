using project01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project01.Services
{
    public class RoomService
    {
        public static void DisplayAllRooms(List<RoomModel> room) 
        {
            //List<RoomModel> room = new List<RoomModel>();

            {
                //foreach (var R in room)

                    foreach (RoomModel R in room)
                {
                    Console.WriteLine($"Room Number : {R.roomNumber} ");
                    Console.WriteLine($"Room Type : {R.roomType} ");
                    Console.WriteLine($"Price Per Night : {R.pricePerNight} ");
                    Console.WriteLine($"I sAvailable? : {R.isAvailable} ");
                }

            }
        }

        public static void DisplayAvailableRooms(List<RoomModel> room1)
        {
            //List<RoomModel> room1 = new List<RoomModel>();
            {
                foreach(RoomModel RM in room1)
                {
                    if ( RM.isAvailable == true)
                    {
                        Console.WriteLine(RM);
                    }
                }
            }

               
        }


        public static void FindRoomByNumber()
        {
            List<RoomModel> room02 = new List<RoomModel>();
            string roomNumbers = "";

            foreach (RoomModel Y in room02)
            {
                if (Y.roomNumber == roomNumbers)
                {
                    Console.WriteLine(Y);
                }

                return;
            }

        }

        public static void CalculateTotalPrice()
        {
            List<RoomModel> room03 = new List<RoomModel>();
            

        }
    }


    }
}
