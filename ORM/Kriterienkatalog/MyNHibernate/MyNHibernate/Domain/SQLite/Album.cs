using System;
using System.Text;
using System.Collections.Generic;


namespace MyNHibernate.Domain.SQLite {
    
    public class Album {
        public virtual int Albumid { get; set; }
        public virtual string Title { get; set; }
        public virtual int Artistid { get; set; }
    }
}
