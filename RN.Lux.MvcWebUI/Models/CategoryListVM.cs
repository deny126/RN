using System.Collections.Generic;
using RN.Lux.Entities.Concrete;

namespace RN.Lux.MvcWebUI.Models
{
    public class CategoryListVM
    {
        public List<Category> Categories { get; internal set; }
        public int CurrentCategory { get; internal set; }
    }
}
