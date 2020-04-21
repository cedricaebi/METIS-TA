using System;
using System.Text;
using System.Collections.Generic;
using Iesi.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Vadditionalcontactinfo {
        public virtual int Businessentityid { get; set; }
        public virtual string Firstname { get; set; }
        public virtual string Middlename { get; set; }
        public virtual string Lastname { get; set; }
        public virtual string Telephonenumber { get; set; }
        public virtual string Telephonespecialinstructions { get; set; }
        public virtual string Street { get; set; }
        public virtual string City { get; set; }
        public virtual string Stateprovince { get; set; }
        public virtual string Postalcode { get; set; }
        public virtual string Countryregion { get; set; }
        public virtual string Homeaddressspecialinstructions { get; set; }
        public virtual string Emailaddress { get; set; }
        public virtual string Emailspecialinstructions { get; set; }
        public virtual string Emailtelephonenumber { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual DateTime Modifieddate { get; set; }
    }
}
