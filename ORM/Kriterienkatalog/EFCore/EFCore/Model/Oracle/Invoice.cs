using System;
using System.Collections.Generic;

namespace EFCore.Model.Oracle
{
    public partial class Invoice
    {
        public Invoice()
        {
            Invoiceline = new HashSet<Invoiceline>();
        }

        public decimal Invoiceid { get; set; }
        public decimal Customerid { get; set; }
        public DateTime Invoicedate { get; set; }
        public string Billingaddress { get; set; }
        public string Billingcity { get; set; }
        public string Billingstate { get; set; }
        public string Billingcountry { get; set; }
        public string Billingpostalcode { get; set; }
        public decimal Total { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<Invoiceline> Invoiceline { get; set; }
    }
}
