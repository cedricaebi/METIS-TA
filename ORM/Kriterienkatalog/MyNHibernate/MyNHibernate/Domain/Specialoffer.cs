using System;
using System.Text;
using System.Collections.Generic;
using Iesi.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Specialoffer {
        public Specialoffer() { }
        public virtual int Specialofferid { get; set; }
        public virtual string Description { get; set; }
        public virtual decimal Discountpct { get; set; }
        public virtual string Type { get; set; }
        public virtual string Category { get; set; }
        public virtual DateTime Startdate { get; set; }
        public virtual DateTime Enddate { get; set; }
        public virtual int Minqty { get; set; }
        public virtual int? Maxqty { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual DateTime Modifieddate { get; set; }
    }
}
