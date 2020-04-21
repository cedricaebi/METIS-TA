using System;
using System.Text;
using System.Collections.Generic;
using Iesi.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Salesorderheader {
        public Salesorderheader() { }
        public virtual int Salesorderid { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Salesperson Salesperson { get; set; }
        public virtual Salesterritory Salesterritory { get; set; }
        public virtual Address Address { get; set; }
        public virtual Shipmethod Shipmethod { get; set; }
        public virtual Creditcard Creditcard { get; set; }
        public virtual Currencyrate Currencyrate { get; set; }
        public virtual byte Revisionnumber { get; set; }
        public virtual DateTime Orderdate { get; set; }
        public virtual DateTime Duedate { get; set; }
        public virtual DateTime? Shipdate { get; set; }
        public virtual byte Status { get; set; }
        public virtual bool Onlineorderflag { get; set; }
        public virtual string Salesordernumber { get; set; }
        public virtual string Purchaseordernumber { get; set; }
        public virtual string Accountnumber { get; set; }
        public virtual string Creditcardapprovalcode { get; set; }
        public virtual decimal Subtotal { get; set; }
        public virtual decimal Taxamt { get; set; }
        public virtual decimal Freight { get; set; }
        public virtual decimal Totaldue { get; set; }
        public virtual string Comment { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual DateTime Modifieddate { get; set; }
    }
}
