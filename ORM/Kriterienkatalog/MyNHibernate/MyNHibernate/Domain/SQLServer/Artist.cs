using System.Collections.Generic;

namespace MyNHibernate.Domain.SQLServer {
    
    public class Artist {
        public Artist() {
			Album = new List<Album>();
        }
        public virtual int Artistid { get; set; }
        public virtual string Name { get; set; }
        public virtual IList<Album> Album { get; set; }
    }
}
