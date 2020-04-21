using System;
using System.Text;
using System.Collections.Generic;
using Iesi.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Person {
        public Person() { }
        public virtual int Businessentityid { get; set; }
        public virtual Businessentity Businessentity { get; set; }
        public virtual string Persontype { get; set; }
        public virtual bool Namestyle { get; set; }
        public virtual string Title { get; set; }
        public virtual string Firstname { get; set; }
        public virtual string Middlename { get; set; }
        public virtual string Lastname { get; set; }
        public virtual string Suffix { get; set; }
        public virtual int Emailpromotion { get; set; }
        public virtual string Additionalcontactinfo { get; set; }
        public virtual string Demographics { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual DateTime Modifieddate { get; set; }
    }
}
