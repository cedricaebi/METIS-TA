using System;
using System.Collections.Generic;

namespace EFCore.Model.Oracle
{
    public partial class Genre
    {
        public Genre()
        {
            Track = new HashSet<Track>();
        }

        public decimal Genreid { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Track> Track { get; set; }
    }
}
