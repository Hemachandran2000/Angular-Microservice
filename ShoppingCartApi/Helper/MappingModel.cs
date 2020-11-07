using System;
using AutoMapper;
using AutoMapper.Mappers;
using ShoppingCartDTO;
using ShoppingCartEntity;

namespace ShoppingCartApi.Helper
{
    public class MappingModel: Profile
    {
        public MappingModel()
        {
            CreateMap<CategoryModel, Categorydto>().ReverseMap();
            CreateMap<SubCategoryModel, SubCategorydto>().ReverseMap();
        }
    }
}
