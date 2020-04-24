using System;
using System.Text;
using System.Collections.Generic;


namespace MyNHibernate.Domain.SQLite {
    
    public class Artist {
        public virtual int Artistid { get; set; }
        public virtual string Name { get; set; }
    }
}
