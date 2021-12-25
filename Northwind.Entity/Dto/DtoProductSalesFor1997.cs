using Northwind.Entity.Base;
using System;
using System.Collections.Generic;

namespace Northwind.Entity.Dto
{
    public class DtoProductSalesFor1997 : DtoBase
    {

        public string CategoryName { get; set; }

        public string ProductName { get; set; }

        public decimal? ProductSales { get; set; }

    }
}
