using System;
using System.Collections.Generic;
using System.Text;
using WebApp.Core.DataAccess;
using WebApp.Entities.Concreate;

namespace WebApp.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        //CustomOperations Product a ait özel operasyonlar yazılır join,sp,view vs...
    }
}
