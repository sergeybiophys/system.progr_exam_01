using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repository
{
    public class ColourRepository:BaseRepository<int,Colour>
    {
        public ColourRepository(ApplicationDbContext ctx) : base(ctx)
        {

        }

        public override Colour Get(int id)
           => Table.FirstOrDefault(c => c.Id == id);

        public override void Remove(int id)
        {
            var colour = Get(id);
            db.Entry(colour).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
        }

        public override void Update(Colour entity)
        {
            var colour = Get(entity.Id);

            colour.Name = entity.Name;

            db.Entry(colour).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
