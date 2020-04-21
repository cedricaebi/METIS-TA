using System;
using System.Text;
using System.Collections.Generic;
using Iesi.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Currencyrate {
        public Currencyrate() { }
        public virtual int Currencyrateid { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual DateTime Currencyratedate { get; set; }
        public virtual decimal Averagerate { get; set; }
        public virtual decimal Endofdayrate { get; set; }
        public virtual DateTime Modifieddate { get; set; }
        public virtual ISet<Salesorderheader> Salesorderheader { get; set; }
    }
}
