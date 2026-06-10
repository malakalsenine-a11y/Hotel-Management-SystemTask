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
        //GuestService(DisplayAllGuests(List<GuestModel>):
        public static void DisplayAllGuests(List<GuestModel> Guests) 
        {

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

        //GuestService(DisplayAllGuests(List<GuestModel>, string guestid)
        public static GuestModel FindGuestById(List<GuestModel> FGuests , string guestid)
        {

                foreach (GuestModel X in FGuests)
                {
                if (X.guestId == guestid)


                    return X;
                }
            return null;
            }
        }
    }

