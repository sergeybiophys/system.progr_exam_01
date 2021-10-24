using Services.Abstract.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstract
{
    public interface ICategoryService
    {
        IEnumerable<CategoryDTO> GetAllCategories();
        CategoryDTO GetCategoryById(int id);
        CategoryDTO UpdateCategory(CategoryDTO category);
        CategoryDTO CreateNewCategory(CategoryDTO category);
        void RemoveCategoryById(int id);
    }
}
