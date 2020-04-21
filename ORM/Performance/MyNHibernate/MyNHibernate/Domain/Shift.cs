using System;
using System.Text;
using System.Collections.Generic;
using Iesi.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Shift {
        public Shift() { }
        public virtual byte Shiftid { get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime Starttime { get; set; }
        public virtual DateTime Endtime { get; set; }
        public virtual DateTime Modifieddate { get; set; }
    }
}
