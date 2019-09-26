using System.Collections.Generic;
using RN.Lux.Entities.Concrete;
namespace RN.Lux.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetByCategoryId(int categoryId);
        void Add(Product product);
        void Update(Product product);
        void Delete(int productId);
    }  
}
