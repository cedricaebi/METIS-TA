using System;
using System.Text;
using System.Collections.Generic;
using Iesi.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Currency {
        public Currency() { }
        public virtual string Currencycode { get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime Modifieddate { get; set; }
        public virtual ISet<Countryregioncurrency> Countryregioncurrency { get; set; }
        public virtual ISet<Currencyrate> FromCurrencyrate { get; set; }
        public virtual ISet<Currencyrate> ToCurrencyrate { get; set; }
    }
}
