using System;
using System.Text;
using System.Collections.Generic;
using Iesi.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Scrapreason {
        public Scrapreason() { }
        public virtual short Scrapreasonid { get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime Modifieddate { get; set; }
    }
}
