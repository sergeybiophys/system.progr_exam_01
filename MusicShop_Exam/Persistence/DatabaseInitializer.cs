using Domain.Entity;
using Persistence.Extensions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    //public class DatabaseInitializer
    //{
    //    public static void Initialize(ApplicationDbContext ctx)
    //    {
    //        ;
    //        if(ctx.Account.Any())
    //        {
    //            return;
    //        }
    //        else
    //        {
    //            string pass = Extension.GetHashPass("admin");
    //            string pass2 = Extension.GetHashPass("service");



    //            var account1 = new Account("admin", "admin", pass, "+380500000123", "admin@mail.ru", true);
    //            var account2 = new Account("service", "service", pass2, "+380661230001", "service@gmail.com", true);

    //            ctx.Account.AddRange(new Account[] { account1, account2 });
    //        }

         

    //        ctx.SaveChanges();
    //    }

    //}
}
