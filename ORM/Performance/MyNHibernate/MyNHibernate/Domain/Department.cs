using System;
using System.Text;
using System.Collections.Generic;
using Iesi.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Department {
        public Department() { }
        public virtual short Departmentid { get; set; }
        public virtual string Name { get; set; }
        public virtual string Groupname { get; set; }
        public virtual DateTime Modifieddate { get; set; }
    }
}
