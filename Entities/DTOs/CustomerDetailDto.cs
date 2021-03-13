﻿using System;
using Core.Entities;

namespace Entities.DTOs
{
    public class CustomerDetailDto:IDto
    {
        public int CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
