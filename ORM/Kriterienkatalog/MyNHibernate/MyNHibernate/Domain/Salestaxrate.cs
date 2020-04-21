using System;
using System.Text;
using System.Collections.Generic;
using Iesi.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Salestaxrate {
        public virtual int Salestaxrateid { get; set; }
        public virtual Stateprovince Stateprovince { get; set; }
        public virtual byte Taxtype { get; set; }
        public virtual decimal Taxrate { get; set; }
        public virtual string Name { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual DateTime Modifieddate { get; set; }
    }
}
