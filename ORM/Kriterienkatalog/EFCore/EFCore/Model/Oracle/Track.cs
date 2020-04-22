using System;
using System.Collections.Generic;

namespace EFCore.Model.Oracle
{
    public partial class Track
    {
        public Track()
        {
            Invoiceline = new HashSet<Invoiceline>();
            Playlisttrack = new HashSet<Playlisttrack>();
        }

        public decimal Trackid { get; set; }
        public string Name { get; set; }
        public decimal? Albumid { get; set; }
        public decimal Mediatypeid { get; set; }
        public decimal? Genreid { get; set; }
        public string Composer { get; set; }
        public decimal Milliseconds { get; set; }
        public decimal? Bytes { get; set; }
        public decimal Unitprice { get; set; }

        public virtual Album Album { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual Mediatype Mediatype { get; set; }
        public virtual ICollection<Invoiceline> Invoiceline { get; set; }
        public virtual ICollection<Playlisttrack> Playlisttrack { get; set; }
    }
}
