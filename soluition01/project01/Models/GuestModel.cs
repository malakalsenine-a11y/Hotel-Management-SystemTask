using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project01.Models
{
    public class GuestModel
    {
        public string guestId { get; set; }
        public string fullName { get; set; } 
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public static string nationality { get; set; } = "Omani";

        //public List <BookingModel> Booking { get; set; }
    }
}
