using System;
using System.Text;
using System.Collections.Generic;
using Iesi.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Vendor {
        public Vendor() { }
        public virtual int Businessentityid { get; set; }
        public virtual Businessentity Businessentity { get; set; }
        public virtual string Accountnumber { get; set; }
        public virtual string Name { get; set; }
        public virtual byte Creditrating { get; set; }
        public virtual bool Preferredvendorstatus { get; set; }
        public virtual bool Activeflag { get; set; }
        public virtual string Purchasingwebserviceurl { get; set; }
        public virtual DateTime Modifieddate { get; set; }
    }
}
