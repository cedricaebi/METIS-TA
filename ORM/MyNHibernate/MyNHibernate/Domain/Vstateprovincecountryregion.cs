using System;
using System.Text;
using System.Collections.Generic;
using Iesi.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Vstateprovincecountryregion {
        public virtual int Stateprovinceid { get; set; }
        public virtual string Stateprovincecode { get; set; }
        public virtual bool Isonlystateprovinceflag { get; set; }
        public virtual string Stateprovincename { get; set; }
        public virtual int Territoryid { get; set; }
        public virtual string Countryregioncode { get; set; }
        public virtual string Countryregionname { get; set; }
    }
}
