using System;
using System.Text;
using System.Collections.Generic;
using Iesi.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Productmodel {
        public Productmodel() { }
        public virtual int Productmodelid { get; set; }
        public virtual string Name { get; set; }
        public virtual string Catalogdescription { get; set; }
        public virtual string Instructions { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual DateTime Modifieddate { get; set; }
    }
}
