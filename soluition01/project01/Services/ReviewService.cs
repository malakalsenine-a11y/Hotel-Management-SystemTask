using project01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project01.Services
{
    public class ReviewService
    {
        //ReviewService(AddReview(BookingModel, ReviewModel))
        public static void AddReview(BookingModel booking , ReviewModel review)
        {
            booking.review.Add(review);
        }

        //ReviewService(DisplayReviewsForBooking(BookingModel))
        public static void DisplayReviewsForBooking(BookingModel DRbooking)
        {

            foreach(ReviewModel  T in DRbooking.review)
            {
                Console.WriteLine($"Review Rating: {T.rating} , Reviews Comment: {T.comment}");
            }

            if ( DRbooking.review == null)
            {
                Console.WriteLine("No reviews yet");
            }
        }
    }
}















