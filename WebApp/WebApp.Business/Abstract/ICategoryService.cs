using System.Collections.Generic;
using WebApp.Entities.Concreate;

namespace WebApp.Business.Abstract
{
    public interface ICategoryService
    {
        void Add(Category category);
        void Delete(Category category);
        List<Category> GetAll();
        void Update(Category category);
    }
}