using System;
using System.Text;
using System.Collections.Generic;
using Iesi.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Creditcard {
        public Creditcard() { }
        public virtual int Creditcardid { get; set; }
        public virtual string Cardtype { get; set; }
        public virtual string Cardnumber { get; set; }
        public virtual byte Expmonth { get; set; }
        public virtual short Expyear { get; set; }
        public virtual DateTime Modifieddate { get; set; }
        public virtual ISet<Personcreditcard> Personcreditcard { get; set; }
        public virtual ISet<Salesorderheader> Salesorderheader { get; set; }
    }
}
