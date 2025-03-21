﻿using System.ComponentModel.DataAnnotations;
namespace bangazon_issues.Models

{
    public class Customers
    {
        [Key]
        public required string Uid { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? PostalCode { get; set; }

        public AccountType? AccountType { get; set; }
        public CustomerOrders? CustomerOrders { get; set; }
    }
}
