using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repository
{
    public class CategoryRepository:BaseRepository<int,Category>
    {
        public CategoryRepository(ApplicationDbContext ctx) : base(ctx)
        {

        }

        public override Category Get(int id)
           => Table.FirstOrDefault(c => c.Id == id);

        public override void Remove(int id)
        {
            var cat = Get(id);
            db.Entry(cat).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
        }

        public override void Update(Category entity)
        {
            var cat = Get(entity.Id);

            cat.Name = entity.Name;
            cat.Guitars = entity.Guitars;

            db.Entry(cat).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
