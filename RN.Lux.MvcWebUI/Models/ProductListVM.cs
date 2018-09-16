using System.Collections.Generic;
using RN.Lux.Entities.Concrete;

namespace RN.Lux.MvcWebUI.Models
{
    public  class ProductListVM
    {
        public int CurrentCategory { get; internal set; }
        public int CurrentPage { get; internal set; }
        public int PageCount { get; internal set; }
        public int PageSize { get; internal set; }
        public List<Product> Products { get; internal set; }
    }
}