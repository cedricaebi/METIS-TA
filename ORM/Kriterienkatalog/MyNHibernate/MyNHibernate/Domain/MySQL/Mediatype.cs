using System;
using System.Text;
using System.Collections.Generic;


namespace MyNHibernate.Domain.MySQL {
    
    public class Mediatype {
        public Mediatype() {
			Track = new List<Track>();
        }
        public virtual int Mediatypeid { get; set; }
        public virtual string Name { get; set; }
        public virtual IList<Track> Track { get; set; }
    }
}
