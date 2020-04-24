using System;
using System.Text;
using System.Collections.Generic;


namespace MyNHibernate.Domain.SQLite {
    
    public class Mediatype {
        public virtual int Mediatypeid { get; set; }
        public virtual string Name { get; set; }
    }
}
