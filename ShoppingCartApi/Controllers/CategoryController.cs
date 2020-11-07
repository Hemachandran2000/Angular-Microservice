using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShoppingCartDAL.UnitOfWork;
using ShoppingCartDTO;
using ShoppingCartEntity;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShoppingCartApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IUnitWork _category;
        private readonly IMapper _mapper;
        public CategoryController(IUnitWork category, IMapper mapper)
        {
            _category = category;
            _mapper = mapper;
        }
        // GET: api/<CategoryController>
        [HttpGet]
        public IEnumerable<Categorydto> Get()
        {
            var categoriesModel = _category.CategoryRepo.GetAll();
            IEnumerable<Categorydto> categoriesdto = _mapper.Map<IEnumerable<Categorydto>>(categoriesModel);
            return categoriesdto;
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public Categorydto Get(Guid id)
        {
            var categoryModel = _category.CategoryRepo.Get(id);
            Categorydto categorydto = _mapper.Map<Categorydto>(categoryModel);
            return categorydto;
        }

        // POST api/<CategoryController>
        [HttpPost]
        public void Post([FromBody] Categorydto category)
        {
            if (category == null)
                return;

            CategoryModel categoryModel = _mapper.Map<CategoryModel>(category);
            categoryModel.CategoryId = Guid.NewGuid();
            _category.CategoryRepo.Add(categoryModel);
            _category.CategoryRepo.Commit();
        }

        // PUT api/<CategoryController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] Categorydto category)
        {
            if (category == null)
                return;

            CategoryModel categoryModel = _mapper.Map<CategoryModel>(category);
            _category.CategoryRepo.Update(categoryModel);
            _category.CategoryRepo.Commit();
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                return;

            _category.CategoryRepo.Delete(Guid.Parse(id));
            _category.CategoryRepo.Commit();
        }
    }
}
