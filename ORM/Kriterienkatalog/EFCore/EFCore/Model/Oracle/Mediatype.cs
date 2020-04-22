using System;
using System.Collections.Generic;

namespace EFCore.Model.Oracle
{
    public partial class Mediatype
    {
        public Mediatype()
        {
            Track = new HashSet<Track>();
        }

        public decimal Mediatypeid { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Track> Track { get; set; }
    }
}
