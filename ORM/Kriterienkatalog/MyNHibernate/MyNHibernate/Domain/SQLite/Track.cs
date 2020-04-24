using System;
using System.Text;
using System.Collections.Generic;


namespace MyNHibernate.Domain.SQLite {
    
    public class Track {
        public virtual int Trackid { get; set; }
        public virtual string Name { get; set; }
        public virtual int? Albumid { get; set; }
        public virtual int Mediatypeid { get; set; }
        public virtual int? Genreid { get; set; }
        public virtual string Composer { get; set; }
        public virtual int Milliseconds { get; set; }
        public virtual int? Bytes { get; set; }
        public virtual double Unitprice { get; set; }
    }
}
