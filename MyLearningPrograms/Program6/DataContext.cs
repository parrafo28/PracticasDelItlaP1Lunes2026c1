using Microsoft.EntityFrameworkCore;
using Program5;
using System;
using System.Collections.Generic;
using System.Text;

namespace Program6
{
    public class DataContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("");
        }
    }
}
