using System;
using System.Text;
using System.Collections.Generic;
using Iesi.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Customer {
        public Customer() { }
        public virtual int Customerid { get; set; }
        public virtual Person Person { get; set; }
        public virtual Store Store { get; set; }
        public virtual Salesterritory Salesterritory { get; set; }
        public virtual string Accountnumber { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual DateTime Modifieddate { get; set; }
        public virtual ISet<Salesorderheader> Salesorderheader { get; set; }
    }
}
