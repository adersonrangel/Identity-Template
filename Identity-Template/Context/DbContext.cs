using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Identity_Template.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Identity_Template.Context
{
    public class TestDbContext : IdentityDbContext<IdentityUser>
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
