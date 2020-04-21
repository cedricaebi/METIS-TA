using System;
using System.Text;
using System.Collections.Generic;
using Iesi.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Jobcandidate {
        public virtual int Jobcandidateid { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual string Resume { get; set; }
        public virtual DateTime Modifieddate { get; set; }
    }
}
