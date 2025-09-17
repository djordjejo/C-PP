using Data;
using Models.Domain_names;
using Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CategoryRepository : Repository<Categories>, ICategoryRepository
    {
        private ProjectDbContext _db;
        public CategoryRepository(ProjectDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task Update(Categories entity)
        {
            if (entity == null)
            {
                throw new InvalidOperationException("Proizvod sa datim ID-om nije pronađen.");
            }
            _db.Update(entity);
        }
    }
}
