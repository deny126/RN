using RN.Lux.Entities.Concrete;
using System.Collections.Generic;
namespace RN.Lux.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
