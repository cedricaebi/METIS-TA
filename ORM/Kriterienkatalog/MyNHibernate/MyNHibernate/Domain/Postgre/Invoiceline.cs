using System;
using System.Text;
using System.Collections.Generic;


namespace MyNHibernate.Domain.Postgre {
    
    public class Invoiceline {
        public virtual int Invoicelineid { get; set; }
        public virtual double Unitprice { get; set; }
        public virtual int Trackid { get; set; }
        public virtual int Quantity { get; set; }
        public virtual int Invoiceid { get; set; }
    }
}
