using System;
using System.Text;
using System.Collections.Generic;


namespace MyNHibernate.Domain.SQLite {
    
    public class Invoice {
        public virtual int Invoiceid { get; set; }
        public virtual int Customerid { get; set; }
        public virtual DateTime Invoicedate { get; set; }
        public virtual string Billingaddress { get; set; }
        public virtual string Billingcity { get; set; }
        public virtual string Billingstate { get; set; }
        public virtual string Billingcountry { get; set; }
        public virtual string Billingpostalcode { get; set; }
        public virtual double Total { get; set; }
    }
}
