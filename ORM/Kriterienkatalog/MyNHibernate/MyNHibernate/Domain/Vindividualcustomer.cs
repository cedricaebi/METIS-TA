using System;
using System.Text;
using System.Collections.Generic;
using Iesi.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Vindividualcustomer {
        public virtual int Businessentityid { get; set; }
        public virtual string Title { get; set; }
        public virtual string Firstname { get; set; }
        public virtual string Middlename { get; set; }
        public virtual string Lastname { get; set; }
        public virtual string Suffix { get; set; }
        public virtual string Phonenumber { get; set; }
        public virtual string Phonenumbertype { get; set; }
        public virtual string Emailaddress { get; set; }
        public virtual int Emailpromotion { get; set; }
        public virtual string Addresstype { get; set; }
        public virtual string Addressline1 { get; set; }
        public virtual string Addressline2 { get; set; }
        public virtual string City { get; set; }
        public virtual string Stateprovincename { get; set; }
        public virtual string Postalcode { get; set; }
        public virtual string Countryregionname { get; set; }
        public virtual string Demographics { get; set; }
    }
}
