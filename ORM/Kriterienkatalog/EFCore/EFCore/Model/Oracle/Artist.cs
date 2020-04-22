using System;
using System.Collections.Generic;

namespace EFCore.Model.Oracle
{
    public partial class Artist
    {
        public Artist()
        {
            Album = new HashSet<Album>();
        }

        public decimal Artistid { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Album> Album { get; set; }
    }
}
