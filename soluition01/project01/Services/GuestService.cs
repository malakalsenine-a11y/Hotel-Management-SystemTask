using project01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project01.Services
{
    public static class GuestService
    {

        public static void DisplayAllGuests() //Methoud
        {
            List<GuestModel> Guests = new List<GuestModel>();

            {
                foreach (GuestModel Guest in Guests)
                {
                    Console.WriteLine($"Guestid Id : {Guest.guestId} ");
                    Console.WriteLine($"FullName : {Guest.fullName} ");
                    Console.WriteLine($"Email : {Guest.phoneNumber} ");
                    Console.WriteLine($"Guestid Id : {Guest.guestId} ");


                }



            }
        }

        public static void FindGuestById()
        {
            string guestid;

            List<GuestModel> FGuests = new List<GuestModel>();
            {
                foreach(GuestModel X in FGuests)
                {
                    if (X guestid == guestId)

                        return;
                }
            }
        }
    }
}
