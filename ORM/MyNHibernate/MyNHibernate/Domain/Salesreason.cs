using System;
using System.Text;
using System.Collections.Generic;
using Iesi.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Salesreason {
        public Salesreason() { }
        public virtual int Salesreasonid { get; set; }
        public virtual string Name { get; set; }
        public virtual string Reasontype { get; set; }
        public virtual DateTime Modifieddate { get; set; }
    }
}
