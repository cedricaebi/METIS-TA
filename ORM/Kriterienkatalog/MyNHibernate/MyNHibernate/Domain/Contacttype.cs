using System;
using System.Text;
using System.Collections.Generic;
using Iesi.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Contacttype {
        public Contacttype() { }
        public virtual int Contacttypeid { get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime Modifieddate { get; set; }
        public virtual ISet<Businessentitycontact> Businessentitycontact { get; set; }
    }
}
