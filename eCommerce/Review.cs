using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce
{
    class Review
    {
        double rating;
        string reviewText;

        //constructor
        public Review(double rating, string reviewText)
        {
            this.rating = rating;
            this.reviewText = reviewText;
        }

        //methods
        public string ReturnReviewText()
        {
            return reviewText;
        }

        public double ReviewRating()
        {
            return rating;
        }
    }
}
