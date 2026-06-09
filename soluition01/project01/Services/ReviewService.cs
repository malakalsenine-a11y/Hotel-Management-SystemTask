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
        public static void AddReview(BookingModel booking , ReviewModel review)
        {
            booking.review.Add(review);
        }

        public static void DisplayReviewsForBooking(List <ReviewModel> DRbooking)
        {

            foreach(ReviewModel  T in DRbooking)
            {
                Console.WriteLine($"Review Rating: {T.rating} , Reviews Comment: {T.comment}");
            }

            if ( DRbooking == null)
            {
                Console.WriteLine("No reviews yet");
            }
        }
    }
}














//AddReview(BookingModel, ReviewModel) void — add the review to booking.bookingReviews.

//DisplayReviewsForBooking(BookingModel) void —print each review's rating and comment. If none exist, print "No reviews yet.". 