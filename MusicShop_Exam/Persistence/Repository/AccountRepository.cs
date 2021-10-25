using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repository
{
    public class AccountRepository:BaseRepository<Guid,Account>
    {
        public AccountRepository(ApplicationDbContext context):base(context)
        {

        }

        public override Account Get(Guid id)
            => Table.FirstOrDefault(a => a.Id == id);

        public override void Remove(Guid id)
        {
            var acc = Get(id);
            db.Entry(acc).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
        }

        public override void Update(Account entity)
        {
            var acc = Get(entity.Id);
            acc.FirstName = entity.FirstName;
            acc.LastName = entity.LastName;
            acc.Password = entity.Password;
            acc.Phone = entity.Phone;
            acc.Email = entity.Email;
            acc.AccountStatus = entity.AccountStatus;

            db.Entry(acc).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
