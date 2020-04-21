using System;
using System.Text;
using System.Collections.Generic;
using Iesi.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Password {
        public virtual int Businessentityid { get; set; }
        public virtual Person Person { get; set; }
        public virtual string Passwordhash { get; set; }
        public virtual string Passwordsalt { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual DateTime Modifieddate { get; set; }
    }
}
