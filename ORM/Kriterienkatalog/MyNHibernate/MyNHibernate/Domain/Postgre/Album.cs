using System;
using System.Text;
using System.Collections.Generic;


namespace MyNHibernate.Domain.Postgre {
    
    public class Album {
        public Album() {
			Track = new List<Track>();
        }
        public virtual int Albumid { get; set; }
        public virtual string Title { get; set; }
        public virtual int Artistid { get; set; }
        public virtual IList<Track> Track { get; set; }
    }
}
