// Author: Moya Goleski
// File: Contact.cs
// Last Updated: 01/24/2022

using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace contact_diary.Models
{
    // inherits from IdentityUser
    public class ApplicationUser : IdentityUser
    {
        public List<Contact> Contacts { get; set; }
    }

    // Contact class
    public class Contact
    {
        // properties for Contact class - getters and setters
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Relation { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public string LandlineNumber { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        // Contact constructor
        public Contact()
        {

        }
    }
}

