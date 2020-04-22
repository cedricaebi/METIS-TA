using System;
using System.Collections.Generic;

namespace EFCore.Model.Oracle
{
    public partial class Playlist
    {
        public Playlist()
        {
            Playlisttrack = new HashSet<Playlisttrack>();
        }

        public decimal Playlistid { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Playlisttrack> Playlisttrack { get; set; }
    }
}
