using System;
using System.Text;
using System.Collections.Generic;
using Iesi.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Stateprovince {
        public Stateprovince() { }
        public virtual int Stateprovinceid { get; set; }
        public virtual Countryregion Countryregion { get; set; }
        public virtual Salesterritory Salesterritory { get; set; }
        public virtual string Stateprovincecode { get; set; }
        public virtual bool Isonlystateprovinceflag { get; set; }
        public virtual string Name { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual DateTime Modifieddate { get; set; }
    }
}
