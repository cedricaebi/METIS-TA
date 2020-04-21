using System;
using System.Text;
using System.Collections.Generic;
using Iesi.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Vstorewithdemographics {
        public virtual int Businessentityid { get; set; }
        public virtual string Name { get; set; }
        public virtual decimal? Annualsales { get; set; }
        public virtual decimal? Annualrevenue { get; set; }
        public virtual string Bankname { get; set; }
        public virtual string Businesstype { get; set; }
        public virtual int? Yearopened { get; set; }
        public virtual string Specialty { get; set; }
        public virtual int? Squarefeet { get; set; }
        public virtual string Brands { get; set; }
        public virtual string Internet { get; set; }
        public virtual int? Numberemployees { get; set; }
    }
}
