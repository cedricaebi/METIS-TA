using System;
using System.Text;
using System.Collections.Generic;
using Iesi.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Addresstype {
        public Addresstype() { }
        public virtual int Addresstypeid { get; set; }
        public virtual string Name { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual DateTime Modifieddate { get; set; }
        public virtual ISet<Businessentityaddress> Businessentityaddress { get; set; }
    }
}
