using System;
using System.Text;
using System.Collections.Generic;
using Iesi.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Vsalespersonsalesbyfiscalyears {
        public virtual int? Salespersonid { get; set; }
        public virtual string Fullname { get; set; }
        public virtual string Jobtitle { get; set; }
        public virtual string Salesterritory { get; set; }
    }
}
