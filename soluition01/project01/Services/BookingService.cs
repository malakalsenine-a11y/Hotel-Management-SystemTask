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
        //BookingService(DisplayAllBookings(List<BookingModel>) 
        public static void  DisplayAllBookings(List <BookingModel> booking)
        {
            foreach(BookingModel BM in booking)
            {
                Console.WriteLine($"BookingId: {BM.bookingId}, GuestId: {BM.guestId},RoomNumber: {BM.roomNumber}, CheckInDate: {BM.checkInDate}, CheckOutDate: {BM.checkOutDate} ,Status:{BM.status}");

            }
        }

        //BookingService(FindBookingById(List<BookingModel>, string bookingId) 
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

        //BookingService(CancelBooking(BookingModel) 
        public static bool CancelBooking(BookingModel CBooking)
        {

            if (CBooking.status == "Cancelled")
            {
                return false;
            }
            else
            {
                CBooking.status = "Cancelled";


                return true;
            }
        }


        //BookingService(CompleteBooking(BookingModel)
        public static bool CompleteBooking(BookingModel ComBooking)
        {
            if (ComBooking.status == "Completed")
            {
                return true;
            }
            else
            {
                ComBooking.status = "Completed";


                return false;
            }
        }





    }
}





