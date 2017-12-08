using System;
using System.Collections.Generic;
using System.Text;
using WebApp.Core.Entities;

namespace WebApp.Entities.Concreate
{
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
