using System;
using System.Text;
using System.Collections.Generic;
using Iesi.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Vemployeedepartmenthistory {
        public virtual int Businessentityid { get; set; }
        public virtual string Title { get; set; }
        public virtual string Firstname { get; set; }
        public virtual string Middlename { get; set; }
        public virtual string Lastname { get; set; }
        public virtual string Suffix { get; set; }
        public virtual string Shift { get; set; }
        public virtual string Department { get; set; }
        public virtual string Groupname { get; set; }
        public virtual DateTime Startdate { get; set; }
        public virtual DateTime? Enddate { get; set; }
    }
}
