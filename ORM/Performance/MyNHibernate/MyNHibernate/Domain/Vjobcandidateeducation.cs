using System;
using System.Text;
using System.Collections.Generic;
using Iesi.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Vjobcandidateeducation {
        public virtual int Jobcandidateid { get; set; }
        public virtual string Edulevel { get; set; }
        public virtual DateTime? Edustartdate { get; set; }
        public virtual DateTime? Eduenddate { get; set; }
        public virtual string Edudegree { get; set; }
        public virtual string Edumajor { get; set; }
        public virtual string Eduminor { get; set; }
        public virtual string Edugpa { get; set; }
        public virtual string Edugpascale { get; set; }
        public virtual string Eduschool { get; set; }
        public virtual string Eduloccountryregion { get; set; }
        public virtual string Edulocstate { get; set; }
        public virtual string Eduloccity { get; set; }
    }
}
