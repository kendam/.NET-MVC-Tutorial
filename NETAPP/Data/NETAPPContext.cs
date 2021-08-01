using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NETAPP.Model;

    public class NETAPPContext : IdentityDbContext<IdentityUser>
    {
        public NETAPPContext (DbContextOptions<NETAPPContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Book { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<Book>().HasData(
            new Book
            {
                ID = 1,
                Title = "DOtNET for absolute beginners",
                Description ="You will a lot",
                Price = 150.99

            });
    }

       
   

    }






     
    
