using System;
using System.Collections.Generic;

namespace EFCore.Model.Oracle
{
    public partial class Playlisttrack
    {
        public decimal Playlistid { get; set; }
        public decimal Trackid { get; set; }

        public virtual Playlist Playlist { get; set; }
        public virtual Track Track { get; set; }
    }
}
