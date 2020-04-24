using System;
using System.Text;
using System.Collections.Generic;


namespace MyNHibernate.Domain.MySQL {
    
    public class Customer {
        public Customer() {
			Invoice = new List<Invoice>();
        }
        public virtual int Customerid { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual string Firstname { get; set; }
        public virtual string Lastname { get; set; }
        public virtual string Company { get; set; }
        public virtual string Address { get; set; }
        public virtual string City { get; set; }
        public virtual string State { get; set; }
        public virtual string Country { get; set; }
        public virtual string Postalcode { get; set; }
        public virtual string Phone { get; set; }
        public virtual string Fax { get; set; }
        public virtual string Email { get; set; }
        public virtual IList<Invoice> Invoice { get; set; }
    }
}
