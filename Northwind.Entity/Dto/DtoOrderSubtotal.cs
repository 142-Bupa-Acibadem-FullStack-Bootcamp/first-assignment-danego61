using Northwind.Entity.Base;
using System;
using System.Collections.Generic;

namespace Northwind.Entity.Dto
{
    public class DtoOrderSubtotal : DtoBase
    {

        public int OrderId { get; set; }

        public decimal? Subtotal { get; set; }

    }
}
