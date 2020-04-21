using System;
using System.Text;
using System.Collections.Generic;
using Iesi.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Workorder {
        public Workorder() { }
        public virtual int Workorderid { get; set; }
        public virtual Product Product { get; set; }
        public virtual Scrapreason Scrapreason { get; set; }
        public virtual int Orderqty { get; set; }
        public virtual int Stockedqty { get; set; }
        public virtual short Scrappedqty { get; set; }
        public virtual DateTime Startdate { get; set; }
        public virtual DateTime? Enddate { get; set; }
        public virtual DateTime Duedate { get; set; }
        public virtual DateTime Modifieddate { get; set; }
    }
}
