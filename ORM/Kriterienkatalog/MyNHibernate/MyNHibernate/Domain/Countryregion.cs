using System;
using System.Text;
using System.Collections.Generic;
using Iesi.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Countryregion {
        public Countryregion() { }
        public virtual string Countryregioncode { get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime Modifieddate { get; set; }
        public virtual ISet<Stateprovince> Stateprovince { get; set; }
    }
}
