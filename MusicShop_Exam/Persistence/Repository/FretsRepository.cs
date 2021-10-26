using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repository
{
    public class FretsRepository:BaseRepository<int, NumberOfFrets>
    {
        public FretsRepository(ApplicationDbContext ctx) : base(ctx)
        {

        }

        public override NumberOfFrets Get(int id)
           => Table.FirstOrDefault(c => c.Id == id);

        public override void Remove(int id)
        {
            var frets = Get(id);
            db.Entry(frets).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
        }

        public override void Update(NumberOfFrets entity)
        {
            var frets = Get(entity.Id);

            frets.Number = entity.Number;

            db.Entry(frets).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
