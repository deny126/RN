using RN.Core.DataAccess.EntityFrameWork;
using RN.Lux.DataAccess.Abstract;
using RN.Lux.Entities.Concrete;

namespace RN.Lux.DataAccess.Concrete.EntityFrameWork
{
    public class EfProductDal:EfRepositoryBase<Product,NorthwindContext>,IProductDal
    {
    }
}
