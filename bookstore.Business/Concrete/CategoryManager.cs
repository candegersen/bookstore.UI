using AutoMapper;
using FluentValidation.Results;
using bookstore.Business.Abstract;
using bookstore.Business.ValidationRules.FluentValidation;
using bookstore.DataAccess.Abstract;
using bookstore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using bookstore.Entities.Dtos;

namespace bookstore.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly IMapper _mapper;
        private readonly ICategoryDal _categoryDal;
        CategoryValidator rule = new CategoryValidator();
        public CategoryManager(ICategoryDal categoryDal, IMapper mapper)
        {
            _mapper = mapper;
            _categoryDal = categoryDal;
        }

        public async Task Add(CategoryDto categoryDto)
        {
            Category newCategory = _mapper.Map<Category>(categoryDto);

            var result = Validator(newCategory);
            if (result.IsValid)
            {
                Category category = await GetCategoryByName(categoryDto.Name);
                if (category is null)
                {
                    await _categoryDal.Add(newCategory);
                    return;
                }
                return;
            }
        }

        public async Task Delete(string name)
        {
            var category = await GetCategoryByName(name);
            if (category != null)
            {
                category.State = false;
                await _categoryDal.Update(category);
            }
        }

        public async Task<Category> GetCategoryById(int id)
        {
            return await _categoryDal.Get(x => x.Id == id);
        }

        public async Task<Category> GetCategoryByName(string categoryName)
        {
            return (await GetList()).FirstOrDefault(x => x.Name == categoryName);
        }

        public async Task<IList<Category>> GetList()
        {
            return (await _categoryDal.GetList()).Where(x => x.State == true).ToList();
        }

        public async Task Update(Category category)
        {
            var result = Validator(category);
            if (result.IsValid)
            {
                await _categoryDal.Update(category);
            }
        }

        public ValidationResult Validator(Category category)
        {
            return rule.Validate(category);
        }


      
    }
}
