using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Persistence.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Account> Account { get; set; }

        //static ApplicationDbContext()
        //{
        //    Database.SetInitializer(new DatabaseInitializer());
        //}
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
            
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=(localdb)\\mssqllocaldb; Database=Music_Shop_Exam; Trusted_Connection=True;MultipleActiveResultSets=true");
        //}

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    string pass = Extension.GetHashPass("admin");
        //    string pass2 = Extension.GetHashPass("service");



        //    var account1 = new Account("admin", "admin", pass, "+380500000123", "admin@mail.ru", true);
        //    var account2 = new Account("service", "service", pass2, "+380661230001", "service@gmail.com", true);



        //    modelBuilder.Entity<Account>().HasData(new Account[]
        //    {
        //        account1,
        //        account2
        //    });
        //}
    }
}
