using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Models.Domain_names;
using Models.DTO;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController: ControllerBase
    {
        private readonly UnitOfWork unitOfWork;
        private IMapper mapper;


        public CategoryController(UnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CategoriesDTO>> Get(Guid id)
        {
            if (id == Guid.Empty)
            {
                return BadRequest();
            }

            var category = await unitOfWork.Category.Get(id);

            if (category == null)
            {
                return NotFound();
            }

            var categoryDTO = mapper.Map<CategoriesDTO>(category);

            return Ok(categoryDTO);
        }
        [HttpPost]
        public async Task<ActionResult> Add(CategoriesDTO categoryDTO)
        {
            if (categoryDTO == null) { return BadRequest(); }

            var category = mapper.Map<Categories>(categoryDTO);

            await unitOfWork.Category.Create(category);
            unitOfWork.Save();

            return CreatedAtAction(nameof(Get), new { id = category.CategoryId }, category);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            if (id == Guid.Empty)
            {
                return BadRequest();
            }

            var category = await unitOfWork.Category.Get(id);

            if (category == null)
            {
                return NotFound();
            }

            unitOfWork.Category.Remove(category);
            unitOfWork.Save();

            return NoContent();
        }


        [HttpPut]
        public async Task<ActionResult> Update(CategoriesDTO categoryDTO)
        {
            if (categoryDTO == null || categoryDTO.CategoryId == Guid.Empty)
            {
                return BadRequest();
            }

            var entityInBase = await unitOfWork.Category.Get(categoryDTO.CategoryId);

            if (entityInBase == null)
            {
                return NotFound();
            }

            mapper.Map(categoryDTO, entityInBase);
            unitOfWork.Category.Update(entityInBase);
            unitOfWork.Save();

            return NoContent();
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoriesDTO>>> GetAll()
        {
            var categories = await unitOfWork.Category.GetAll();
            var categoryDTO = mapper.Map<IEnumerable<CategoriesDTO>>(categories);

            return Ok(categoryDTO);
        }

    }
}
