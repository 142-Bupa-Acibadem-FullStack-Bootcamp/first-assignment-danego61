using Northwind.Entity.Base;
using System;
using System.Collections.Generic;

namespace Northwind.Entity.Dto
{
    public class DtoSalesTotalsByAmount : DtoBase
    {

        public decimal? SaleAmount { get; set; }

        public int OrderId { get; set; }

        public string CompanyName { get; set; }

        public DateTime? ShippedDate { get; set; }

    }
}
