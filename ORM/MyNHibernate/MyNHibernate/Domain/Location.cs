using System;
using System.Text;
using System.Collections.Generic;
using Iesi.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Location {
        public Location() { }
        public virtual short Locationid { get; set; }
        public virtual string Name { get; set; }
        public virtual decimal Costrate { get; set; }
        public virtual decimal Availability { get; set; }
        public virtual DateTime Modifieddate { get; set; }
    }
}
