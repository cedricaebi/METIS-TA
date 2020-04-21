using System;
using System.Text;
using System.Collections.Generic;
using Iesi.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Productinventory {
        public virtual int Productid { get; set; }
        public virtual short Locationid { get; set; }
        public virtual Product Product { get; set; }
        public virtual Location Location { get; set; }
        public virtual string Shelf { get; set; }
        public virtual byte Bin { get; set; }
        public virtual short Quantity { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual DateTime Modifieddate { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as Productinventory;
			if (t == null) return false;
			if (Productid == t.Productid
			 && Locationid == t.Locationid)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ Productid.GetHashCode();
			hash = (hash * 397) ^ Locationid.GetHashCode();

			return hash;
        }
        #endregion
    }
}
