using Entities.Concrete;
using System.Collections.Generic;

namespace Bussiness.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        Category GetById(int categoryId);

      
    }
}
