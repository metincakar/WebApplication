using System;
using System.Collections.Generic;
using System.Text;
using WebApp.Core.Entities;

namespace WebApp.Entities.Concreate
{
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }

        public decimal UnitPrice { get; set; }
        public int MyProperty { get; set; }

        public short UnitsInStock { get; set; }
    }
}
