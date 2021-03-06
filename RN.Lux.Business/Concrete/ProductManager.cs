using System.Collections.Generic;
using RN.Lux.Business.Abstract;
using RN.Lux.DataAccess.Abstract;
using RN.Lux.Entities.Concrete;

namespace RN.Lux.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }
        public List<Product> GetByCategoryId(int categoryId)
        {
            return _productDal.GetList(p => p.CategoryID == categoryId || categoryId == 0);
        }
        public void Add(Product product)
        {
           _productDal.Add(product);
        }
        public void Delete(int productId)
        {
           _productDal.Delete(new Product(){ProductId = productId});
        }       
        public void Update(Product product)
        {
           _productDal.Update(product);
        }
    }
}
