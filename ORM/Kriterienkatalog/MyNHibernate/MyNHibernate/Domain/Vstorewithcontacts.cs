using System;
using System.Text;
using System.Collections.Generic;
using Iesi.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Vstorewithcontacts {
        public virtual int Businessentityid { get; set; }
        public virtual string Name { get; set; }
        public virtual string Contacttype { get; set; }
        public virtual string Title { get; set; }
        public virtual string Firstname { get; set; }
        public virtual string Middlename { get; set; }
        public virtual string Lastname { get; set; }
        public virtual string Suffix { get; set; }
        public virtual string Phonenumber { get; set; }
        public virtual string Phonenumbertype { get; set; }
        public virtual string Emailaddress { get; set; }
        public virtual int Emailpromotion { get; set; }
    }
}
