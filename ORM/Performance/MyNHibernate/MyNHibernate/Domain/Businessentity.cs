using System;
using System.Text;
using System.Collections.Generic;
using Iesi.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Businessentity {
        public Businessentity() { }
        public virtual int Businessentityid { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual DateTime Modifieddate { get; set; }
        public virtual ISet<Businessentityaddress> Businessentityaddress { get; set; }
        public virtual ISet<Businessentitycontact> Businessentitycontact { get; set; }
        public virtual ISet<Person> Person { get; set; }
    }
}
