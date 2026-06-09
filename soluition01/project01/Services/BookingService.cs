using project01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace project01.Services
{
    public class BookingService
    {
      public static void  DisplayAllBookings(List <BookingModel> booking)
        {
            foreach(BookingModel BM in booking)
            {
                Console.WriteLine($"BookingId: {BM.bookingId}, GuestId: {BM.guestId},RoomNumber: {BM.roomNumber}, CheckInDate: {BM.checkInDate}, CheckOutDate: {BM.checkOutDate} ,Status:{BM.status}");

            }
        }

      public static BookingModel FindBookingById (List<BookingModel> FBooking, string bookingId)
        {
            foreach(BookingModel FB in FBooking)
            {
                if (FB.bookingId == bookingId)
                {
                    return FB;

                }
            }

            return null;
        }

      public static bool CancelBooking(List<BookingModel> CBooking)
        {
            bool Cancelled = true;
            foreach (BookingModel CB in CBooking)
            {
                if (CB.status == "Cancelled")
                {
                    return true;
                }
                else
                {

                }
            }
            return false;
        }

      //public static bool CompleteBooking(List<BookingModel> ComBooking)
      //  {
      //      return;
      //  }





    }
}






//CompleteBooking(BookingModel)
//bool — set status to "Completed" 
//and set the linked room's isAvailable back to true. 
//Accept the RoomModel as a