using AutoMapper;
using Models.Domain_names;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapping
{
    public class AutoMapperProfile : Profile
    {
        public  AutoMapperProfile()
       {
            CreateMap<ProductsDTO, Products>().ReverseMap();
            CreateMap<CategoriesDTO, Categories>().ReverseMap();
        }

       
    }
}
