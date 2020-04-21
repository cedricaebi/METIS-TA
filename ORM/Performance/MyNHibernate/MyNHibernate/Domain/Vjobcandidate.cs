using System;
using System.Text;
using System.Collections.Generic;
using Iesi.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Vjobcandidate {
        public virtual int Jobcandidateid { get; set; }
        public virtual int? Businessentityid { get; set; }
        public virtual string Nameprefix { get; set; }
        public virtual string Namefirst { get; set; }
        public virtual string Namemiddle { get; set; }
        public virtual string Namelast { get; set; }
        public virtual string Namesuffix { get; set; }
        public virtual string Skills { get; set; }
        public virtual string Addrtype { get; set; }
        public virtual string Addrloccountryregion { get; set; }
        public virtual string Addrlocstate { get; set; }
        public virtual string Addrloccity { get; set; }
        public virtual string Addrpostalcode { get; set; }
        public virtual string Email { get; set; }
        public virtual string Website { get; set; }
        public virtual DateTime Modifieddate { get; set; }
    }
}
