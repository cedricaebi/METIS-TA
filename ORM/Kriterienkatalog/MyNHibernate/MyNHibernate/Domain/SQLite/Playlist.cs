using System;
using System.Text;
using System.Collections.Generic;


namespace MyNHibernate.Domain.SQLite {
    
    public class Playlist {
        public virtual int Playlistid { get; set; }
        public virtual string Name { get; set; }
    }
}
