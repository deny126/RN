using System;
using System.Collections.Generic;
using System.Text;
using RN.Core.DataAccess.EntityFrameWork;
using RN.Lux.DataAccess.Abstract;
using RN.Lux.Entities.Concrete;

namespace RN.Lux.DataAccess.Concrete.EntityFrameWork
{
    public class EfCategoryDal : EfRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {
    }
}
