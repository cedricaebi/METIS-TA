using System;
using System.Text;
using System.Collections.Generic;
using Iesi.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Vjobcandidateemployment {
        public virtual int Jobcandidateid { get; set; }
        public virtual DateTime? Empstartdate { get; set; }
        public virtual DateTime? Empenddate { get; set; }
        public virtual string Emporgname { get; set; }
        public virtual string Empjobtitle { get; set; }
        public virtual string Empresponsibility { get; set; }
        public virtual string Empfunctioncategory { get; set; }
        public virtual string Empindustrycategory { get; set; }
        public virtual string Emploccountryregion { get; set; }
        public virtual string Emplocstate { get; set; }
        public virtual string Emploccity { get; set; }
    }
}
