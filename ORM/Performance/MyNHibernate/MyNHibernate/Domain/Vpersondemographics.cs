using System;
using System.Text;
using System.Collections.Generic;
using Iesi.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Vpersondemographics {
        public virtual int Businessentityid { get; set; }
        public virtual decimal? Totalpurchaseytd { get; set; }
        public virtual DateTime? Datefirstpurchase { get; set; }
        public virtual DateTime? Birthdate { get; set; }
        public virtual string Maritalstatus { get; set; }
        public virtual string Yearlyincome { get; set; }
        public virtual string Gender { get; set; }
        public virtual int? Totalchildren { get; set; }
        public virtual int? Numberchildrenathome { get; set; }
        public virtual string Education { get; set; }
        public virtual string Occupation { get; set; }
        public virtual bool? Homeownerflag { get; set; }
        public virtual int? Numbercarsowned { get; set; }
    }
}
