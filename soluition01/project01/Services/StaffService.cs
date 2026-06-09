using project01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project01.Services
{
    public class StaffService
    {
        public static void DisplayAllStaff(List <StaffModel> staff)
        {
            foreach (StaffModel SM in staff) {
                Console.WriteLine($"Staff Id: {SM.staffId},Full Name: {SM.fullName}, Role:{SM.role},Is On Duty:{SM.isOnDuty}  ");

            }
        }

        public static StaffModel FindStaffById(List <StaffModel> staf , string staffid)
        {
            foreach(StaffModel S in staf)
            {
                if (S.staffId == staffid)
                {
                    return S;
                }
            }

            return null;
        }

        public static void ToggleDutyStatus(StaffModel s)
        {
         if(s.isOnDuty == true)
            {
                s.isOnDuty = false;
                Console.WriteLine($"staff: {s.fullName} Duty Status is update to false");
            }

            else
            {
                s.isOnDuty = true;
                Console.WriteLine($"staff: {s.fullName} Duty Status is update to false");
            }
        }
    }
}


