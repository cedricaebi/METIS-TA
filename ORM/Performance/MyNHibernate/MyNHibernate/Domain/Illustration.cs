using System;
using System.Text;
using System.Collections.Generic;
using Iesi.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Illustration {
        public Illustration() { }
        public virtual int Illustrationid { get; set; }
        public virtual string Diagram { get; set; }
        public virtual DateTime Modifieddate { get; set; }
    }
}
