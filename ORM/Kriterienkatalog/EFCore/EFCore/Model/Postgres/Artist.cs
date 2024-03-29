﻿using System;
using System.Collections.Generic;

namespace EFCore.Model.Postgres
{
    public partial class Artist
    {
        public Artist()
        {
            Album = new HashSet<Album>();
        }

        public int ArtistId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Album> Album { get; set; }
    }
}
