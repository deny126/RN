using RN.Lux.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace RN.Lux.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
