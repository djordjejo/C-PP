using Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        Task <IEnumerable<T>> GetAll();
        Task<T> Get(Guid id);
        Task Create(T entity);
        void Remove(T entity);
    }
}
