using System;
using System.Text;
using System.Collections.Generic;
using Iesi.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Billofmaterials {
        public virtual int Billofmaterialsid { get; set; }
        public virtual Product Product { get; set; }
        public virtual Unitmeasure Unitmeasure { get; set; }
        public virtual DateTime Startdate { get; set; }
        public virtual DateTime? Enddate { get; set; }
        public virtual short Bomlevel { get; set; }
        public virtual decimal Perassemblyqty { get; set; }
        public virtual DateTime Modifieddate { get; set; }
    }
}
