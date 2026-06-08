using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace project01.Models
{
    public class ReviewModel
    {
        public string reviewId { get; set; }
        public string bookingId { get; set; }
        public int rating  { get; set; }
        public string comment { get; set; }





    }
}
