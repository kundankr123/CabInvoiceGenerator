﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class Ride
    {
        public double Distance { get; set; }
        public double Time { get; set; }
        public double Fare { get; set; }

        public Ride(double distance, double time)
        {
            Distance = distance;
            Time = time;
            Fare = (distance * 10) + (time * 1);

            if (Fare < 5)
            {
                Fare = 5;
            }
        }
    }

    public class NormalRide : Ride
    {
        public NormalRide(double distance, double time) : base(distance, time)
        {
            Fare = (distance * 10) + (time * 1);

            if (Fare < 5)
            {
                Fare = 5;
            }
        }
    }

    public class PremiumRide : Ride
    {
        public PremiumRide(double distance, double time) : base(distance, time)
        {
            Fare = (distance * 15) + (time * 2);

            if (Fare < 20)
            {
                Fare = 20;
            }
        }

    }
}
