using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework322.Models
{
    public class BookDataContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Publisher> Publishers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=LAPTOP-6CVTIS2E ;Database = pubbookDb; Trusted_Connection= True;TrustServerCertificate=true");
        }

    }
}
