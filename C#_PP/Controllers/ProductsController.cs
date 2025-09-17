using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Models.Domain_names;
using Models.DTO;
using Repository;

namespace Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly UnitOfWork unitOfWork;
        private IMapper mapper;


        public ProductsController(UnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductsDTO>> Get(Guid id)
        {
            if (id == Guid.Empty)
            {
                return BadRequest();
            }

            var product = await unitOfWork.Product.Get(id);

            if (product == null)
            {
                return NotFound();
            }

            var productDTO = mapper.Map<ProductsDTO>(product);

            return Ok(productDTO);
        }
        [HttpPost]
        public async Task<ActionResult> Add(ProductsDTO productDTO)
        { 
            if(productDTO == null) { return BadRequest(); }

            var product = mapper.Map<Products>(productDTO);

            await unitOfWork.Product.Create(product);
            unitOfWork.Save();

            return CreatedAtAction(nameof(Get), new { id = product.ProductId }, product);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            if (id == Guid.Empty)
            {
                return BadRequest();
            }

            var product = await unitOfWork.Product.Get(id);

            if (product == null)
            {
                return NotFound();
            }

            unitOfWork.Product.Remove(product);
            unitOfWork.Save();

            return NoContent();
        }

       
        [HttpPut]
        public async Task<ActionResult> Update(ProductsDTO productDTO)
        {
            if (productDTO == null || productDTO.ProductId == Guid.Empty)
            {
                return BadRequest();
            }

            var entityInBase = await unitOfWork.Product.Get(productDTO.ProductId);

            if (entityInBase == null)
            {
                return NotFound();
            }

            mapper.Map(productDTO, entityInBase);
            unitOfWork.Product.Update(entityInBase);
            unitOfWork.Save();

            return NoContent();
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductsDTO>>> GetAll()
        {
            var products = await unitOfWork.Product.GetAll();
            var productsDTO = mapper.Map<IEnumerable<ProductsDTO>>(products);

            return Ok(productsDTO);
        }

    }
}
