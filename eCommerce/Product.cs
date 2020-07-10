using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce
{
    class Product
    {
        int skuNumber;
        string name;
        string category;
        double price;
        double averageRating;
        List<Review> reviews;

        //constructor
        public Product(int skuNumber, string name, string category, double price)
        {
            this.skuNumber = skuNumber;
            this.name = name;
            this.category = category;
            this.price = price;
            averageRating = 0;
            reviews = new List<Review>();
        }

        //methods
        public int sku()
        {
            return skuNumber;
        }

        public string Name()
        {
            return name;
        }
        public string Category()
        {
            return category;
        }

        public double Price()
        {
            return price;
        }

        public void ShowReview()
        {
            Console.WriteLine("\nRating\tReview");
            Console.WriteLine("------------------------");
            foreach (Review review in reviews)
            {
                Console.WriteLine($"{review.ReviewRating()}\t{review.ReturnReviewText()}");
            }
        }

        public double AverageRating()
        {
            averageRating = 0;
            foreach (Review review in reviews)
            {
                averageRating += review.ReviewRating();
            }
            averageRating /= reviews.Count();
            return averageRating;
        }

        public void AddReview()
        {
            Console.Write("\nPlease add a rating from 1-5: ");
            double rating = double.Parse(Console.ReadLine());
            Console.WriteLine("Please write your review below:");
            string review = Console.ReadLine();
            reviews.Add(new Review(rating, review));
        }
    }
}
