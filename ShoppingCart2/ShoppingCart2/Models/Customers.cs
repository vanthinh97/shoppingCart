using System;
using System.Collections.Generic;

#nullable disable

namespace ShoppingCart2.Models
{
    public partial class Customers
    {
        public Customers()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Gender { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        public string Email { get; set; }
        public Guid? MainAddressId { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string Password { get; set; }
        public bool NewsLetterOpted { get; set; }
    }
}
