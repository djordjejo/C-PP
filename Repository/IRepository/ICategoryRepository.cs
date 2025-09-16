using Models.Domain_names;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Categories>
    {
        void Update(Categories entity);
    }
}
