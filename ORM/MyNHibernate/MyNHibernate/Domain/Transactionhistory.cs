using System;
using System.Text;
using System.Collections.Generic;
using Iesi.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Transactionhistory {
        public virtual int Transactionid { get; set; }
        public virtual Product Product { get; set; }
        public virtual int Referenceorderid { get; set; }
        public virtual int Referenceorderlineid { get; set; }
        public virtual DateTime Transactiondate { get; set; }
        public virtual string Transactiontype { get; set; }
        public virtual int Quantity { get; set; }
        public virtual decimal Actualcost { get; set; }
        public virtual DateTime Modifieddate { get; set; }
    }
}
