using System;
using System.Text;
using System.Collections.Generic;


namespace MyNHibernate.Domain.SQLite {
    
    public class Genre {
        public virtual int Genreid { get; set; }
        public virtual string Name { get; set; }
    }
}
