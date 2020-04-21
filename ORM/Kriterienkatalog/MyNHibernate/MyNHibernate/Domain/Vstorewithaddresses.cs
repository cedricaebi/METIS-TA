using System;
using System.Text;
using System.Collections.Generic;
using Iesi.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Vstorewithaddresses {
        public virtual int Businessentityid { get; set; }
        public virtual string Name { get; set; }
        public virtual string Addresstype { get; set; }
        public virtual string Addressline1 { get; set; }
        public virtual string Addressline2 { get; set; }
        public virtual string City { get; set; }
        public virtual string Stateprovincename { get; set; }
        public virtual string Postalcode { get; set; }
        public virtual string Countryregionname { get; set; }
    }
}
