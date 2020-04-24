using System;
using System.Text;
using System.Collections.Generic;


namespace MyNHibernate.Domain.SQLite {
    
    public class Playlisttrack {
        public virtual int Playlistid { get; set; }
        public virtual int Trackid { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as Playlisttrack;
			if (t == null) return false;
			if (Playlistid == t.Playlistid
			 && Trackid == t.Trackid)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ Playlistid.GetHashCode();
			hash = (hash * 397) ^ Trackid.GetHashCode();

			return hash;
        }
        #endregion
    }
}
