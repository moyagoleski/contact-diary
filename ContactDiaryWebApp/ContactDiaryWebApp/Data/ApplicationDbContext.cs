// Author: Moya Goleski
// File: ApplicationDbContext.cs
// Last Updated: 01/24/2022

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using contact_diary.Models;

namespace ContactDiaryWebApp.Data
{
    // public class ApplicationDbContext : IdentityDbContext
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Contact> Contact { get; set; }
    }
}
