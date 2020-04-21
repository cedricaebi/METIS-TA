using System;
using System.Text;
using System.Collections.Generic;
using Iesi.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Culture {
        public Culture() { }
        public virtual string Cultureid { get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime Modifieddate { get; set; }
        public virtual ISet<Productmodelproductdescriptionculture> Productmodelproductdescriptionculture { get; set; }
    }
}
