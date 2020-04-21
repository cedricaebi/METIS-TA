using System;
using System.Text;
using System.Collections.Generic;
using Iesi.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Shipmethod {
        public Shipmethod() { }
        public virtual int Shipmethodid { get; set; }
        public virtual string Name { get; set; }
        public virtual decimal Shipbase { get; set; }
        public virtual decimal Shiprate { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual DateTime Modifieddate { get; set; }
    }
}
