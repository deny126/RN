﻿using System;
using System.Collections.Generic;
using System.Text;
using RN.Core.Entities;

namespace RN.Lux.Entities.Concrete
{
    public class Category:IEntityBase
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
