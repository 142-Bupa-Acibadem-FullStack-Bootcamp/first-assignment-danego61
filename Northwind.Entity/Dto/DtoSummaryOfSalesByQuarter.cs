using Northwind.Entity.Base;
using System;
using System.Collections.Generic;

namespace Northwind.Entity.Dto
{
    public class DtoSummaryOfSalesByQuarter : DtoBase
    {

        public DateTime? ShippedDate { get; set; }

        public int OrderId { get; set; }

        public decimal? Subtotal { get; set; }

    }
}
