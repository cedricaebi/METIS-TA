using System;
using System.Text;
using System.Collections.Generic;
using Iesi.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Productsubcategory {
        public Productsubcategory() { }
        public virtual int Productsubcategoryid { get; set; }
        public virtual Productcategory Productcategory { get; set; }
        public virtual string Name { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual DateTime Modifieddate { get; set; }
    }
}
