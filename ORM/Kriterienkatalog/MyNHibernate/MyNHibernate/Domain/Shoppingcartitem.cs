using System;
using System.Text;
using System.Collections.Generic;
using Iesi.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Shoppingcartitem {
        public virtual int Shoppingcartitemid { get; set; }
        public virtual Product Product { get; set; }
        public virtual string Shoppingcartid { get; set; }
        public virtual int Quantity { get; set; }
        public virtual DateTime Datecreated { get; set; }
        public virtual DateTime Modifieddate { get; set; }
    }
}
