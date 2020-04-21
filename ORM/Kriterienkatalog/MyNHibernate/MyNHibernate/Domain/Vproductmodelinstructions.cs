using System;
using System.Text;
using System.Collections.Generic;
using Iesi.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Vproductmodelinstructions {
        public virtual int Productmodelid { get; set; }
        public virtual string Name { get; set; }
        public virtual string Instructions { get; set; }
        public virtual int? Locationid { get; set; }
        public virtual decimal? Setuphours { get; set; }
        public virtual decimal? Machinehours { get; set; }
        public virtual decimal? Laborhours { get; set; }
        public virtual int? Lotsize { get; set; }
        public virtual string Step { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual DateTime Modifieddate { get; set; }
    }
}
