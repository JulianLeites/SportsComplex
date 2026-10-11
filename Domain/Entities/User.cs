using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    internal class User
    {
        public int Id { get; set; }
        public string FirtsName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public DateTime CreatedAt { get; set; }
        public string PhoneNumber { get; set; }
        public int DNI { get; set; }
    }
}
