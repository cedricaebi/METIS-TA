using System;
using System.Text;
using System.Collections.Generic;
using Iesi.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Salesorderdetail {
        public virtual int Salesorderid { get; set; }
        public virtual int Salesorderdetailid { get; set; }
        public virtual Salesorderheader Salesorderheader { get; set; }
        public virtual Specialofferproduct Specialofferproduct { get; set; }
        public virtual string Carriertrackingnumber { get; set; }
        public virtual short Orderqty { get; set; }
        public virtual decimal Unitprice { get; set; }
        public virtual decimal Unitpricediscount { get; set; }
        public virtual double Linetotal { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual DateTime Modifieddate { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as Salesorderdetail;
			if (t == null) return false;
			if (Salesorderid == t.Salesorderid
			 && Salesorderdetailid == t.Salesorderdetailid)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ Salesorderid.GetHashCode();
			hash = (hash * 397) ^ Salesorderdetailid.GetHashCode();

			return hash;
        }
        #endregion
    }
}
