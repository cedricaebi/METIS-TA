using System;
using System.Text;
using System.Collections.Generic;
using Iesi.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Specialofferproduct {
        public Specialofferproduct() { }
        public virtual int Specialofferid { get; set; }
        public virtual int Productid { get; set; }
        public virtual Specialoffer Specialoffer { get; set; }
        public virtual Product Product { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual DateTime Modifieddate { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as Specialofferproduct;
			if (t == null) return false;
			if (Specialofferid == t.Specialofferid
			 && Productid == t.Productid)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ Specialofferid.GetHashCode();
			hash = (hash * 397) ^ Productid.GetHashCode();

			return hash;
        }
        #endregion
    }
}
