using System;
using System.Collections.Generic;
using System.Text;
using WebApp.Core.DataAccess.EntityFramework;
using WebApp.DataAccess.Abstract;
using WebApp.Entities.Concreate;

namespace WebApp.DataAccess.Concreate.EntityFramework
{
    public class EfProductDal:EfEntityRepositoryBase<Product,WebAppContext>,IProductDal
    {

    }
    public class EfCategoryDal : EfEntityRepositoryBase<Category, WebAppContext>, ICategoryDal
    {

    }

}
