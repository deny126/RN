using System;
using System.Collections.Generic;
using System.Text;
using RN.Lux.Business.Abstract;
using RN.Lux.DataAccess.Abstract;
using RN.Lux.Entities.Concrete;

namespace RN.Lux.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }
    }
}
