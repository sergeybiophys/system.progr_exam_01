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
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Colour> Colours { get; set; }
        public DbSet<Guitar> Guitars { get; set; }
        public DbSet<GuitarType> GuitarTypes { get; set; }
        public DbSet<Kind> Kinds { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<NumberOfFrets> NumberOfFrets { get; set; }
        public DbSet<NumberOfString> NumberOfStrings { get; set; }
        public DbSet<Pickup> Pickups { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Status> Statuses { get; set; }
        //static ApplicationDbContext()
        //{
        //    Database.SetInitializer(new DatabaseInitializer());
        //}
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
           // Database.EnsureDeleted();
            Database.EnsureCreated();
            
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=(localdb)\\mssqllocaldb; Database=Music_Shop_Exam; Trusted_Connection=True;MultipleActiveResultSets=true");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            string pass = Extension.GetHashPass("admin");
            string pass2 = Extension.GetHashPass("service");


            var account1 = new Account("admin", "admin", pass, "+380500000123", "admin@mail.ru", true);
            var account2 = new Account("service", "service", pass2, "+380661230001", "service@gmail.com", true);
            account1.Id = Guid.Parse("9bcd41ee-c9ab-4b89-8016-a30937449ab9");
            account2.Id = Guid.Parse("48f9af64-2ecb-4f92-a911-90b6bc0d2c6f");


            modelBuilder.Entity<Account>().HasData(new Account[]
            {
                account1,
                account2
            });

            var category1 = new Category
            {
                Id = 1,
                Name = "guitar"
            };

            modelBuilder.Entity<Category>().HasData(new Category[]
            {
                category1
            });

            var colour1 = new Colour
            {
                Id = 1,
                Name = "white"
            };

            var colour2 = new Colour
            {
                Id = 2,
                Name = "black"
            };
            var colour3 = new Colour
            {
                Id = 3,
                Name = "brown"
            };
            var colour4 = new Colour
            {
                Id = 4,
                Name = "red"
            };
            var colour5 = new Colour
            {
                Id = 5,
                Name = "yellow"
            };
            var colour6 = new Colour
            {
                Id = 6,
                Name = "green"
            };
            var colour7 = new Colour
            {
                Id = 7,
                Name = "blue"
            };

            modelBuilder.Entity<Colour>().HasData(new Colour[]
            {
                   colour1,
                   colour2,
                   colour3,
                   colour4,
                   colour5,
                   colour6,
                   colour7

            });

            var type1 = new GuitarType
            {
                Id = 1,
                Name = "Acoustic"
            };
            var type2 = new GuitarType
            {
                Id = 2,
                Name = "Guitar Kits"
            };
            var type3 = new GuitarType
            {
                Id = 3,
                Name = "Electro-Acoustic"
            };

            modelBuilder.Entity<GuitarType>().HasData(new GuitarType[]
            {
                type1,
                type2,
                type3
            });


            var kind1 = new Kind
            {
                Id = 1,
                Name = "Left-handed"
            };
            var kind2 = new Kind
            {
                Id = 2,
                Name = "Right-handed"
            };

            modelBuilder.Entity<Kind>().HasData(new Kind[]
            {
                kind1,
                kind2
            });

            var manuf1 = new Manufacturer
            {
                Id = 1,
                Name = "Epiphone"
            };
            var manuf2 = new Manufacturer
            {
                Id = 2,
                Name = "Fender"
            };
            var manuf3 = new Manufacturer
            {
                Id = 3,
                Name = "Gibson"
            };
            var manuf4 = new Manufacturer
            {
                Id = 4,
                Name = "Gretsch"
            };
            var manuf5 = new Manufacturer
            {
                Id = 5,
                Name = "Takamine"
            };
            var manuf6 = new Manufacturer
            {
                Id = 6,
                Name = "Yamaha"
            };
            modelBuilder.Entity<Manufacturer>().HasData(new Manufacturer[]
            {
                   manuf1,
                   manuf2,
                   manuf3,
                   manuf4,
                   manuf5,
                   manuf6

            });

            var frets1 = new NumberOfFrets
            {
                Id = 1,
                Number = 16
            };
            var frets2 = new NumberOfFrets
            {
                Id = 2,
                Number = 18
            };
            var frets3 = new NumberOfFrets
            {
                Id = 3,
                Number = 19
            };
            var frets4 = new NumberOfFrets
            {
                Id = 4,
                Number = 22
            };

            modelBuilder.Entity<NumberOfFrets>().HasData(new NumberOfFrets[]
            {
                   frets1,
                   frets2,
                   frets3,
                   frets4

            });

            var string1 = new NumberOfString
            {
                Id = 1,
                Number = 6
            };
            var string2 = new NumberOfString
            {
                Id = 2,
                Number = 12
            };


            modelBuilder.Entity<NumberOfString>().HasData(new NumberOfString[]
            {
                   string1,
                   string2
            });

            var pickup1 = new Pickup
            {
                Id = 1,
                Type = "N/A"
            };
            var pickup2 = new Pickup
            {
                Id = 2,
                Type = "Piezo Pickup"
            };
            var pickup3 = new Pickup
            {
                Id = 3,
                Type = "Electromagnetic"
            };

            modelBuilder.Entity<Pickup>().HasData(new Pickup[]
            {
                   pickup1,
                   pickup2,
                   pickup3
            });

            var size1 = new Size
            {
                Id = 1,
                InstrumentSize = "3/4"
            };
            var size2 = new Size
            {
                Id = 2,
                InstrumentSize = "Full-size"
            };
            var size3 = new Size
            {
                Id = 3,
                InstrumentSize = "Reduced"
            };


            modelBuilder.Entity<Size>().HasData(new Size[]
            {
                   size1,
                   size2,
                   size3
            });

            var status1 = new Status
            {
                Id = 1,
                Name = "Top"
            };
            var status2 = new Status
            {
                Id = 2,
                Name = "New"
            };
            var status3 = new Status
            {
                Id = 3,
                Name = "Sale"
            };
            var status4 = new Status
            {
                Id = 4,
                Name = "Expected"
            };

            modelBuilder.Entity<Status>().HasData(new Status[]
            {
                   status1,
                   status2,
                   status3,
                   status4
            });

            var guitar1 = new Guitar
            {
                Id = 1,
                Name = "EF9552",
                Price = 1900,
                Quantity = 10,
                Image = "/img/black.jpg",
                CategoryId = 1,

                ManufacturerId = 1,

                ColourId = 2,
                GuitarTypeId = 3,
                KindId = 2,
                NumberOfFretsId = 4,
                NumberOfStringId = 1,
                PickupId = 2,
                SizeId = 2,
                Status = 1

            };
            var guitar2 = new Guitar
            {
                Id = 2,
                Name = "DFG098-E4",
                Price = 2400,
                Quantity = 20,
                Image = "/img/blackwhite1.jpg",
                CategoryId = 1,

                ManufacturerId = 2,

                ColourId = 2,
                GuitarTypeId = 3,
                KindId = 2,
                NumberOfFretsId = 4,
                NumberOfStringId = 1,
                PickupId = 3,
                SizeId = 2,
                Status = 1

            };
            var guitar3 = new Guitar
            {
                Id = 3,
                Name = "UU44-SKL",
                Price = 1100,
                Quantity = 5,
                Image = "/img/blue1.jpg",
                CategoryId = 1,

                ManufacturerId = 3,

                ColourId = 7,
                GuitarTypeId = 3,
                KindId = 2,
                NumberOfFretsId = 3,
                NumberOfStringId = 1,
                PickupId = 3,
                SizeId = 2,
                Status = 2

            };

            var guitar4 = new Guitar
            {
                Id = 4,
                Name = "HQkLL09",
                Price = 1100,
                Quantity = 5,
                Image = "/img/brown1.jpg",
                CategoryId = 1,

                ManufacturerId = 4,

                ColourId = 3,
                GuitarTypeId = 1,
                KindId = 1,
                NumberOfFretsId = 3,
                NumberOfStringId = 1,
                PickupId = 1,
                SizeId = 2,
                Status = 2

            };

            var guitar5 = new Guitar
            {
                Id = 5,
                Name = "GR-78",
                Price = 2150,
                Quantity = 15,
                Image = "/img/darkblue1.jpg",
                CategoryId = 1,

                ManufacturerId = 5,

                ColourId = 7,
                GuitarTypeId = 3,
                KindId = 2,
                NumberOfFretsId = 4,
                NumberOfStringId = 1,
                PickupId = 2,
                SizeId = 2,
                Status = 3

            };

            var guitar6 = new Guitar
            {
                Id = 6,
                Name = "MF-23KL",
                Price = 700,
                Quantity = 15,
                Image = "/img/darkred1.jpg",
                CategoryId = 1,

                ManufacturerId = 6,

                ColourId = 4,
                GuitarTypeId = 3,
                KindId = 2,
                NumberOfFretsId = 3,
                NumberOfStringId = 1,
                PickupId = 3,
                SizeId = 3,
                Status = 1
            };

            var guitar7 = new Guitar
            {
                Id = 7,
                Name = "OOEd0-JJ",
                Price = 3200,
                Quantity = 25,
                Image = "/img/darkred2.jpg",
                CategoryId = 1,

                ManufacturerId = 1,

                ColourId = 4,
                GuitarTypeId = 3,
                KindId = 2,
                NumberOfFretsId = 3,
                NumberOfStringId = 1,
                PickupId = 3,
                SizeId = 3,
                Status = 1
            };

            var guitar8 = new Guitar
            {
                Id = 8,
                Name = "HJ-88-OP",
                Price = 2150,
                Quantity = 10,
                Image = "/img/green1.jpg",
                CategoryId = 1,

                ManufacturerId = 2,

                ColourId = 6,
                GuitarTypeId = 3,
                KindId = 2,
                NumberOfFretsId = 3,
                NumberOfStringId = 1,
                PickupId = 3,
                SizeId = 3,
                Status = 1
            };

            var guitar9 = new Guitar
            {
                Id = 9,
                Name = "99STMP",
                Price = 1350,
                Quantity = 10,
                Image = "/img/green2.jpg",
                CategoryId = 1,
                ManufacturerId = 3,
                ColourId = 6,
                GuitarTypeId = 3,
                KindId = 2,
                NumberOfFretsId = 3,
                NumberOfStringId = 1,
                PickupId = 3,
                SizeId = 3,
                Status = 1
            };

            var guitar10 = new Guitar
            {
                Id = 10,
                Name = "100-STMP",
                Price = 890,
                Quantity = 10,
                Image = "/img/red1.jpg",
                CategoryId = 1,

                ManufacturerId = 3,

                ColourId = 4,
                GuitarTypeId = 3,
                KindId = 2,
                NumberOfFretsId = 3,
                NumberOfStringId = 1,
                PickupId = 3,
                SizeId = 3,
                Status = 1
            };
            var guitar11 = new Guitar
            {
                Id = 11,
                Name = "AAD5-0",
                Price = 890,
                Quantity = 10,
                Image = "/img/white1.jpg",
                CategoryId = 1,

                ManufacturerId = 4,

                ColourId = 1,
                GuitarTypeId = 3,
                KindId = 2,
                NumberOfFretsId = 3,
                NumberOfStringId = 1,
                PickupId = 2,
                SizeId = 3,
                Status = 2
            };
            var guitar12 = new Guitar
            {
                Id = 12,
                Name = "TWC-4",
                Price = 3000,
                Quantity = 10,
                Image = "/img/yellow1.jpg",
                CategoryId = 1,

                ManufacturerId = 5,

                ColourId = 5,
                GuitarTypeId = 3,
                KindId = 1,
                NumberOfFretsId = 3,
                NumberOfStringId = 1,
                PickupId = 2,
                SizeId = 3,
                Status = 2
            };

            modelBuilder.Entity<Guitar>().HasData(new Guitar[]
            {
                   guitar1,
                   guitar2,
                   guitar3,
                   guitar4,
                   guitar5,
                   guitar6,
                   guitar7,
                   guitar8,
                   guitar9,
                   guitar10,
                   guitar11,
                   guitar12,
             });
        }
    }
}
