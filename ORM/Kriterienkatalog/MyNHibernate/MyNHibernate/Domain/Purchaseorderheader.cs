using System;
using System.Text;
using System.Collections.Generic;
using Iesi.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Purchaseorderheader {
        public Purchaseorderheader() { }
        public virtual int Purchaseorderid { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual Shipmethod Shipmethod { get; set; }
        public virtual byte Revisionnumber { get; set; }
        public virtual byte Status { get; set; }
        public virtual DateTime Orderdate { get; set; }
        public virtual DateTime? Shipdate { get; set; }
        public virtual decimal Subtotal { get; set; }
        public virtual decimal Taxamt { get; set; }
        public virtual decimal Freight { get; set; }
        public virtual decimal Totaldue { get; set; }
        public virtual DateTime Modifieddate { get; set; }
    }
}
