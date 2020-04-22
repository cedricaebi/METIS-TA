using System;
using System.Collections.Generic;

namespace EFCore.Model.Oracle
{
    public partial class Invoiceline
    {
        public decimal Invoicelineid { get; set; }
        public decimal Invoiceid { get; set; }
        public decimal Trackid { get; set; }
        public decimal Unitprice { get; set; }
        public decimal Quantity { get; set; }

        public virtual Invoice Invoice { get; set; }
        public virtual Track Track { get; set; }
    }
}
