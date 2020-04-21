using System;
using System.Text;
using System.Collections.Generic;
using Iesi.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Productdescription {
        public Productdescription() { }
        public virtual int Productdescriptionid { get; set; }
        public virtual string Description { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual DateTime Modifieddate { get; set; }
    }
}
