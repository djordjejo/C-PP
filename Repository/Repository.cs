using Data;
using Microsoft.EntityFrameworkCore;
using Models.DTO;
using Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ProjectDbContext _db;
        internal DbSet<T> dbSet;

        public Repository(ProjectDbContext db)
        {
            _db = db;
            this.dbSet = _db.Set<T>();
        }

        public async Task Create(T entity)
        {
           await dbSet.AddAsync(entity);
        }

        public async Task<T> Get(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(id), "Prosleđen prazan ID.");
            }

            return await dbSet.FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await dbSet.ToListAsync();
        }

        public void Remove(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException("Prosledjen prazan objekat");
            dbSet.Remove(entity);
        }


       
    }
}
