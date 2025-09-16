using Models.Domain_names;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.IRepository
{
    public interface IProductRepository : IRepository<Products>
    {
        Task Update(Products entity);

    }
}
