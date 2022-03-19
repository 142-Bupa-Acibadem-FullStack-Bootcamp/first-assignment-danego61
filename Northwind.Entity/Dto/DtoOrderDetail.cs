using Northwind.Entity.Base;
using System;
using System.Collections.Generic;

namespace Northwind.Entity.Dto
{
    public class DtoOrderDetail : DtoBase
    {

        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public decimal UnitPrice { get; set; }

        public short Quantity { get; set; }

        public float Discount { get; set; }
      
    }
}
