using System;
using System.Linq;
using System.Collections.Generic;

namespace ProductReviewManagementUsingLinq
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Product Review Management");
            Management management = new Management();

            //UC1- Add 25 Default Value List for product review

            List<ProductReview> productReviewList = new List<ProductReview>();

            productReviewList.Add(new ProductReview() { ProductID = 1, UserID = 1, Rating = 5, Review = "Nice", isLike = true });
            productReviewList.Add(new ProductReview() { ProductID = 2, UserID = 1, Rating = 7, Review = "Good", isLike = false });
            productReviewList.Add(new ProductReview() { ProductID = 3, UserID = 2, Rating = 4, Review = "Nice", isLike = true });
            productReviewList.Add(new ProductReview() { ProductID = 4, UserID = 2, Rating = 3, Review = "Bad", isLike = true });
            productReviewList.Add(new ProductReview() { ProductID = 5, UserID = 2, Rating = 6, Review = "Good", isLike = false });
            productReviewList.Add(new ProductReview() { ProductID = 6, UserID = 2, Rating = 2, Review = "Bad", isLike = true });
            productReviewList.Add(new ProductReview() { ProductID = 7, UserID = 2, Rating = 1, Review = "Bad", isLike = false });
            productReviewList.Add(new ProductReview() { ProductID = 8, UserID = 2, Rating = 8, Review = "Very Nice", isLike = false });
            productReviewList.Add(new ProductReview() { ProductID = 9, UserID = 3, Rating = 9, Review = "Very Nice", isLike = true });
            productReviewList.Add(new ProductReview() { ProductID = 10, UserID = 3, Rating = 8, Review = "Very Nice", isLike = true });
            productReviewList.Add(new ProductReview() { ProductID = 11, UserID = 3, Rating = 8, Review = "Good", isLike = true });
            productReviewList.Add(new ProductReview() { ProductID = 12, UserID = 3, Rating = 5, Review = "Nice", isLike = true });
            productReviewList.Add(new ProductReview() { ProductID = 13, UserID = 3, Rating = 7, Review = "Good", isLike = false });
            productReviewList.Add(new ProductReview() { ProductID = 14, UserID = 10, Rating = 3, Review = "Good", isLike = true });
            productReviewList.Add(new ProductReview() { ProductID = 15, UserID = 10, Rating = 6, Review = "Good", isLike = false });
            productReviewList.Add(new ProductReview() { ProductID = 16, UserID = 10, Rating = 2, Review = "Bad", isLike = true });
            productReviewList.Add(new ProductReview() { ProductID = 17, UserID = 10, Rating = 1, Review = "Bad", isLike = false });
            productReviewList.Add(new ProductReview() { ProductID = 18, UserID = 10, Rating = 10, Review = "Very Nice", isLike = false });
            productReviewList.Add(new ProductReview() { ProductID = 19, UserID = 10, Rating = 8, Review = "Very Nice", isLike = true });
            productReviewList.Add(new ProductReview() { ProductID = 20, UserID = 12, Rating = 8, Review = "Very Nice", isLike = true });
            productReviewList.Add(new ProductReview() { ProductID = 21, UserID = 12, Rating = 8, Review = "Good", isLike = true });
            productReviewList.Add(new ProductReview() { ProductID = 22, UserID = 12, Rating = 5, Review = "Nice", isLike = true });
            productReviewList.Add(new ProductReview() { ProductID = 23, UserID = 12, Rating = 7, Review = "Good", isLike = false });
            productReviewList.Add(new ProductReview() { ProductID = 24, UserID = 12, Rating = 3, Review = "Bad", isLike = true });
            productReviewList.Add(new ProductReview() { ProductID = 25, UserID = 12, Rating = 6, Review = "Good", isLike = false });

            //Display list



            Console.WriteLine("Select \n1)Create ProductReview Class with 25 Default values\n2)Retrive Top 3 Records of Top 3 Rating Values\n3)Details from Records(1,4,9) with rating>3\n4)count review of each product id\n5) retrieve product id or review only\n6)Skip top 5 Records" +
                "\n7)Create Datatable\n8)Retreive details who's islike value is true\n9)Average Rating of Each Product\n10)Records Whose Review is Nice\n11)Records whose UserID=10 and Order by rating");
            int option = Convert.ToInt16(Console.ReadLine());
            switch (option)
            {
                case 1:
                    foreach (var list in productReviewList)
                    {
                        Console.WriteLine("ProductID :" + list.ProductID + "  " + "UserID :" + list.UserID + "  " + "Rating :" + list.Rating + "  " + "Review :" + list.Review + "  " + "isLike :" + list.isLike);
                    }
                    break;
                case 2:
                    management.TopRecords(productReviewList);
                    break;
                case 3:
                    management.RetriveRecords(productReviewList);
                    break;
                case 4:
                    management.CountRecordsbyProductID(productReviewList);
                    break;
                case 5:
                    management.RetriveProductIdOrReview(productReviewList);
                    break;
                case 6:
                    management.SkipTop5Records(productReviewList);
                    break;
                case 7:
                    management.Datatables();
                    break;
                case 8:
                    management.RetriveRecords_IsLike_True(productReviewList);
                    break;
                case 9:
                    management.AvgRating(productReviewList);
                    break;
                case 10:
                    management.RetriveRecordsReviewIS_Nice(productReviewList);
                    break;
                case 11:
                    management.RetriveRecordsUser1d_10(productReviewList);
                    break;
                default:
                    Console.WriteLine("Please choose the correct option!");
                    break;
            }
        }
    }
    
}