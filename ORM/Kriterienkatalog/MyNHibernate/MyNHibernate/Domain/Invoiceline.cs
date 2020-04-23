using System;
using System.Text;
using System.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Invoiceline {
        public virtual int Invoicelineid { get; set; }
        public virtual Invoice Invoice { get; set; }
        public virtual Track Track { get; set; }
        public virtual double Unitprice { get; set; }
        public virtual int Quantity { get; set; }
    }
}
