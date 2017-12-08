using System;
using System.Collections.Generic;
using System.Text;
using WebApp.Business.Abstract;
using WebApp.DataAccess.Abstract;
using WebApp.Entities.Concreate;

namespace WebApp.Business.Concreate
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public List<Category> GetAll()
        {
           return _categoryDal.GetList();
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}
