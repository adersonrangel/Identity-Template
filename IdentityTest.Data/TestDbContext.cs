using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using IdentityTest.Data.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace IdentityTest.Data
{
    public class TestDbContext :  IdentityDbContext<CustomIdentity, IdentityRole<Guid>, Guid>
    {
        /// <summary>
        /// Class constructor
        /// </summary>
        public TestDbContext(DbContextOptions<TestDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
