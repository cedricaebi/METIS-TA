using System.Collections.Generic;

namespace MyNHibernate.Domain.SQLServer {
    
    public class Track {
        public Track() {
			Invoiceline = new List<Invoiceline>();
			Playlisttrack = new List<Playlisttrack>();
        }
        public virtual int Trackid { get; set; }
        public virtual Album Album { get; set; }
        public virtual Mediatype Mediatype { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual string Name { get; set; }
        public virtual string Composer { get; set; }
        public virtual int Milliseconds { get; set; }
        public virtual int? Bytes { get; set; }
        public virtual double Unitprice { get; set; }
        public virtual IList<Invoiceline> Invoiceline { get; set; }
        public virtual IList<Playlisttrack> Playlisttrack { get; set; }
    }
}
