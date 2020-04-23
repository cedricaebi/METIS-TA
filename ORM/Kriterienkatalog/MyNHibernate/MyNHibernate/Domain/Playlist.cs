using System;
using System.Text;
using System.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Playlist {
        public Playlist() {
			Playlisttrack = new List<Playlisttrack>();
        }
        public virtual int Playlistid { get; set; }
        public virtual string Name { get; set; }
        public virtual IList<Playlisttrack> Playlisttrack { get; set; }
    }
}
