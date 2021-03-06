using System;
using Core.Entities;

namespace Entities.DTOs
{
    public class UserForRegister:IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}
