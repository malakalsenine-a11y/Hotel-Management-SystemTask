using project01.Models;
using project01.Services;
using System.Security.Cryptography.X509Certificates;

namespace project01
{
    public class Program
    {



        //RegisterGuest
        public static void RegisterGuest(HotelContext context)
        {

            Console.WriteLine("Enter the guest id :");
            string guestId = Console.ReadLine();

            Console.WriteLine("Enter full name :");
            string fullName = Console.ReadLine();

            Console.WriteLine("Enter the email :");
            string email = Console.ReadLine();

            Console.WriteLine("Enter the phone number :");
            string phoneNumber = Console.ReadLine();

            context.guests.Add(new GuestModel
            {
                guestId = guestId,
                fullName = fullName,
                email = email,
                phoneNumber = phoneNumber,

                Booking = new List<BookingModel>()
            });


            EmailService.SendEmail(
                email,

                "Welcome to Grand Codeline Hotel",
                "Thank you for registering. We look forward to hosting you!"

                );
            Console.WriteLine("Guest Registered Successfully.");


        }

        //AddRoom
        public static void AddRoom(HotelContext context)
        {
            Console.WriteLine("Enter the Room Number :");
            string roomNumber = Console.ReadLine();

            Console.WriteLine("Enter the Room Type :");
            string roomType = Console.ReadLine();

            Console.WriteLine("Enter tprice Per Night :");
            double pricePerNight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter floor :");
            int floor = Convert.ToInt32(Console.ReadLine());

            RoomModel room = new RoomModel
            {
                roomNumber = roomNumber,
                roomType = roomType,
                pricePerNight = pricePerNight,
                floor = floor,
                isAvailable = true
            };
            context.rooms.Add(room);
            Console.WriteLine("Room Add is Successfully");
        }

        //DisplayAvailableRooms
        public static void DisplayAvailableRooms(HotelContext context)
        {
            if (context.rooms.Count == 0)
            {
                Console.WriteLine("No Room in System");
            }
            else
            {
                RoomService.DisplayAllRooms(context.rooms);
            }
        }

        //AddStaff
        public static void AddStaff(HotelContext context)
        {
            Console.WriteLine("Enter the staff id :");
            string staffId = Console.ReadLine();

            Console.WriteLine("Enter full name :");
            string fullName = Console.ReadLine();

            Console.WriteLine("Enter the role :");
            string role = Console.ReadLine();

            Console.WriteLine("Enter the email :");
            string email = Console.ReadLine();


            StaffModel staff = new StaffModel
            {
                staffId = staffId,
                fullName = fullName,
                role = role,
                email = email,
                isOnDuty = true
            };

            context.staff.Add(staff);

            Console.WriteLine("Staff Added Successfully.");
        }

        //    public static void DisplayAllStaff(HotelContext context)
        //{

        //}

        static void Main(string[] args)
        {
            
        }
    }
}




