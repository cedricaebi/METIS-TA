using System;
using System.Collections.Generic;

namespace EFCore.Model.Oracle
{
    public partial class Album
    {
        public Album()
        {
            Track = new HashSet<Track>();
        }

        public decimal Albumid { get; set; }
        public string Title { get; set; }
        public decimal Artistid { get; set; }

        public virtual Artist Artist { get; set; }
        public virtual ICollection<Track> Track { get; set; }
    }
}
