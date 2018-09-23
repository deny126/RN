using System;
using System.Collections.Generic;
using System.Text;
using RN.Core.Entities;

namespace RN.Lux.Entities.Concrete
{
    public class Product : IEntityBase
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryID { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
    }
}
