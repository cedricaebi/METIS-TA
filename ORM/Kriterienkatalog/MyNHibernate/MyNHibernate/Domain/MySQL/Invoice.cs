using System;
using System.Text;
using System.Collections.Generic;


namespace MyNHibernate.Domain.MySQL {
    
    public class Invoice {
        public Invoice() {
			Invoiceline = new List<Invoiceline>();
        }
        public virtual int Invoiceid { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual DateTime Invoicedate { get; set; }
        public virtual string Billingaddress { get; set; }
        public virtual string Billingcity { get; set; }
        public virtual string Billingstate { get; set; }
        public virtual string Billingcountry { get; set; }
        public virtual string Billingpostalcode { get; set; }
        public virtual string Total { get; set; }
        public virtual IList<Invoiceline> Invoiceline { get; set; }
    }
}
