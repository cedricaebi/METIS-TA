using System;
using System.Text;
using System.Collections.Generic;
using Iesi.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Vproductanddescription {
        public virtual int Productid { get; set; }
        public virtual string Name { get; set; }
        public virtual string Productmodel { get; set; }
        public virtual string Cultureid { get; set; }
        public virtual string Description { get; set; }
    }
}
