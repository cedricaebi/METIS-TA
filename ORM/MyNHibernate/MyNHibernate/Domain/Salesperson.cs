using System;
using System.Text;
using System.Collections.Generic;
using Iesi.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Salesperson {
        public Salesperson() { }
        public virtual int Businessentityid { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Salesterritory Salesterritory { get; set; }
        public virtual decimal? Salesquota { get; set; }
        public virtual decimal Bonus { get; set; }
        public virtual decimal Commissionpct { get; set; }
        public virtual decimal Salesytd { get; set; }
        public virtual decimal Saleslastyear { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual DateTime Modifieddate { get; set; }
    }
}
