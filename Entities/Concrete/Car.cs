﻿using System;
using Core.Entities;

namespace Entities.Concrate
{
    public class Car:IEntity
    {
        public Car()
        {
        }

        public int CarId { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int ModelYear { get; set; }
        public double DailyPrice { get; set; }
        public string Description { get; set; }
    }
}
