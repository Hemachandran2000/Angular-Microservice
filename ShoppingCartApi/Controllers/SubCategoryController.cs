using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingCartDAL.UnitOfWork;
using ShoppingCartDTO;
using AutoMapper;
using ShoppingCartEntity;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShoppingCartApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubCategoryController : ControllerBase
    {
        private readonly IUnitWork _subCategory;
        private readonly IMapper _mapper;
        public SubCategoryController(IUnitWork subCategory, IMapper mapper)
        {
            _subCategory = subCategory;
            _mapper = mapper;
        }
        // GET: api/<SubCategoryController>
        [HttpGet]
        public IEnumerable<SubCategorydto> Get()
        {
            var subCategoriesModel = _subCategory.SubCategoryRepo.GetAll();
            IEnumerable<SubCategorydto> subCategoriesdto = _mapper.Map<IEnumerable<SubCategorydto>>(subCategoriesModel);
            return subCategoriesdto;
        }

        // GET api/<SubCategoryController>/5
        [HttpGet("{id}")]
        public SubCategorydto Get(Guid id)
        {
            var subCategoryModel = _subCategory.SubCategoryRepo.Get(id);
            SubCategorydto subCategorydto = _mapper.Map<SubCategorydto>(subCategoryModel);
            return subCategorydto;
        }

        // POST api/<SubCategoryController>
        [HttpPost]
        public void Post([FromBody] SubCategorydto subcategory)
        {
            if (subcategory == null)
                return;

            SubCategoryModel subCategoryModel = _mapper.Map<SubCategoryModel>(subcategory);
            subCategoryModel.SubCategoryId = Guid.NewGuid();
            _subCategory.SubCategoryRepo.Add(subCategoryModel);
            _subCategory.SubCategoryRepo.Commit();
        }

        // PUT api/<SubCategoryController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] SubCategorydto subcategory)
        {
            if (subcategory == null)
                return;

            SubCategoryModel subCategoryModel = _mapper.Map<SubCategoryModel>(subcategory);
            subCategoryModel.SubCategoryId = Guid.NewGuid();
            subCategoryModel.CategoryId = Guid.NewGuid().ToString();
            _subCategory.SubCategoryRepo.Update(subCategoryModel);
            _subCategory.SubCategoryRepo.Commit();
        }

        // DELETE api/<SubCategoryController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                return;

            _subCategory.CategoryRepo.Delete(Guid.Parse(id));
            _subCategory.CategoryRepo.Commit();
        }
    }
}
