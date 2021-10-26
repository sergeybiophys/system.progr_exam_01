﻿using Domain.Entity;
using Microsoft.EntityFrameworkCore;
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
            Database.EnsureCreated();

        }

    }
}
