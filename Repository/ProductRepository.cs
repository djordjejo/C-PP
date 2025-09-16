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
    public class ProductRepository : Repository<Products>, IProductRepository
    {
        private ProjectDbContext _db;
        public ProductRepository(ProjectDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Products entity)
        { 
            _db.Update(entity); 
        }
    }
}
