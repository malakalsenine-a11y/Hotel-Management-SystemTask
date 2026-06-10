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
        //RoomService(DisplayAllRooms(List<RoomModel>) 
        public static void DisplayAllRooms(List<RoomModel> room) 
        {
                    foreach (RoomModel R in room)
                {
                    Console.WriteLine($"Room Number : {R.roomNumber} ");
                    Console.WriteLine($"Room Type : {R.roomType} ");
                    Console.WriteLine($"Price Per Night : {R.pricePerNight} ");
                    Console.WriteLine($"Price Per Night : {R.isAvailable} ");

            }

        }

        //RoomService(DisplayAvailableRooms(List<RoomModel>) 
        public static void DisplayAvailableRooms(List<RoomModel> room1)
        {
                foreach(RoomModel RM in room1)
                {
                    if (RM.isAvailable == true)
                    {
                        Console.WriteLine($"Room Number : {RM.roomNumber}, Room Type : {RM.roomType}, Price Per Night : {RM.pricePerNight} ");
                    }
                }
            }

        //RoomService(FindRoomByNumber(List<RoomModel>, string roomNumber) 
        public static RoomModel FindRoomByNumber(List<RoomModel> room02 , string roomNumbers)
        {
            foreach (RoomModel Y in room02)
            {
                if (Y.roomNumber == roomNumbers)
                {
                    return Y;
                }

            }
            return null;
        }

        //RoomService(CalculateTotalPrice(RoomModel, int nights)
        public static double CalculateTotalPrice(RoomModel room, int nights)
        {
            return room.pricePerNight * nights;
        }





    }
    }


    

 
