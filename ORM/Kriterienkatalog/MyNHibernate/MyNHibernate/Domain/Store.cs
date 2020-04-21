using System;
using System.Text;
using System.Collections.Generic;
using Iesi.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Store {
        public Store() { }
        public virtual int Businessentityid { get; set; }
        public virtual Businessentity Businessentity { get; set; }
        public virtual Salesperson Salesperson { get; set; }
        public virtual string Name { get; set; }
        public virtual string Demographics { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual DateTime Modifieddate { get; set; }
    }
}
