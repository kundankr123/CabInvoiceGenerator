﻿namespace CabInvoiceGenerator
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to master branch of Cab Invoice Generator.");
            
            int numRides;
            double distance, time, fare, totalFare = 0;

            Console.WriteLine("Enter the number of rides: ");
            numRides = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= numRides; i++)
            {
                Console.WriteLine("Ride " + i);
                Console.WriteLine("Enter the distance travelled in km: ");
                distance = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the time taken in minutes: ");
                time = Convert.ToDouble(Console.ReadLine());

                fare = (distance * 10) + (time * 1);

                if (fare < 5)
                {
                    fare = 5;
                }

                Console.WriteLine("Total fare for ride " + i + ": Rs. " + fare);

                totalFare += fare;
            }

            int totalNumFares = numRides;
            double averageFare = totalFare / numRides;


            Console.WriteLine("*****************************************************");
            Console.WriteLine("Total number of fares: " + totalNumFares);
            Console.WriteLine("Total fare for all rides: Rs. " + totalFare);
            Console.WriteLine("Average fare: Rs. " + averageFare);
        }
    }
}