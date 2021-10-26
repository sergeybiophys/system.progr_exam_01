using AutoMapper;
using Domain.Entity;
using Domain.Repository;
using Services.Abstract;
using Services.Abstract.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CategoryService : ICategoryService
    {
        readonly IUnitOfWork uow;
        readonly IMapper mapper;
        public CategoryService(IUnitOfWork uow,
                               IMapper mapper)
        {
            this.uow = uow;
            this.mapper = mapper;
        }
        public CategoryDTO CreateNewCategory(CategoryDTO category)
        {
            var tmp = new Category
            {
                Name = category.Name,
                Guitars = new List<Guitar>()
            };

            this.uow.CategoriesRepository.Create(tmp);
            this.uow.SaveChanges();

            return mapper.Map<CategoryDTO>(tmp);
        }

        public IEnumerable<CategoryDTO> GetAllCategories()
        {
            var categories = this.uow.CategoriesRepository.GetAll();

            return categories.Select((c) => new CategoryDTO
            {
                Id = c.Id,
                CreatedAt = c.CreatedAt,
                Name = c.Name,
                Guitars = mapper.Map<ICollection<GuitarDTO>>(c.Guitars)
            }).ToList();
        }

        public CategoryDTO GetCategoryById(int id)
        {
            var cat = this.uow.CategoriesRepository.Get(id);
            return new CategoryDTO
            {
                Id = cat.Id,
                CreatedAt = cat.CreatedAt,
                Name = cat.Name,
                Guitars = mapper.Map<ICollection<GuitarDTO>>(cat.Guitars)
            };
        }

        public void RemoveCategoryById(int id)
        {
            this.uow.CategoriesRepository.Remove(id);
            this.uow.SaveChanges();
        }

        public CategoryDTO UpdateCategory(CategoryDTO category)
        {
            var tmp = new Category
            {
                Id = category.Id,
                Name = category.Name,
                CreatedAt = category.CreatedAt,
                Guitars = mapper.Map<ICollection<Guitar>>(category.Guitars)
            };

            this.uow.CategoriesRepository.Update(tmp);
            this.uow.SaveChanges();

            return mapper.Map<CategoryDTO>(tmp);
        }
    }
}
