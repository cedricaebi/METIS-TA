using System;
using System.Text;
using System.Collections.Generic;
using Iesi.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Employee {
        public Employee() { }
        public virtual int Businessentityid { get; set; }
        public virtual Person Person { get; set; }
        public virtual string Nationalidnumber { get; set; }
        public virtual string Loginid { get; set; }
        public virtual string Organizationnode { get; set; }
        public virtual short? Organizationlevel { get; set; }
        public virtual string Jobtitle { get; set; }
        public virtual DateTime Birthdate { get; set; }
        public virtual string Maritalstatus { get; set; }
        public virtual string Gender { get; set; }
        public virtual DateTime Hiredate { get; set; }
        public virtual bool Salariedflag { get; set; }
        public virtual short Vacationhours { get; set; }
        public virtual short Sickleavehours { get; set; }
        public virtual bool Currentflag { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual DateTime Modifieddate { get; set; }
    }
}
