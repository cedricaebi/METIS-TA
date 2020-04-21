using System;
using System.Text;
using System.Collections.Generic;
using Iesi.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Productreview {
        public virtual int Productreviewid { get; set; }
        public virtual Product Product { get; set; }
        public virtual string Reviewername { get; set; }
        public virtual DateTime Reviewdate { get; set; }
        public virtual string Emailaddress { get; set; }
        public virtual int Rating { get; set; }
        public virtual string Comments { get; set; }
        public virtual DateTime Modifieddate { get; set; }
    }
}
