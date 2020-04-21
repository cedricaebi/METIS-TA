using System;
using System.Text;
using System.Collections.Generic;
using Iesi.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Vproductmodelcatalogdescription {
        public virtual int Productmodelid { get; set; }
        public virtual string Name { get; set; }
        public virtual string Summary { get; set; }
        public virtual string Manufacturer { get; set; }
        public virtual string Copyright { get; set; }
        public virtual string Producturl { get; set; }
        public virtual string Warrantyperiod { get; set; }
        public virtual string Warrantydescription { get; set; }
        public virtual string Noofyears { get; set; }
        public virtual string Maintenancedescription { get; set; }
        public virtual string Wheel { get; set; }
        public virtual string Saddle { get; set; }
        public virtual string Pedal { get; set; }
        public virtual string Bikeframe { get; set; }
        public virtual string Crankset { get; set; }
        public virtual string Pictureangle { get; set; }
        public virtual string Picturesize { get; set; }
        public virtual string Productphotoid { get; set; }
        public virtual string Material { get; set; }
        public virtual string Color { get; set; }
        public virtual string Productline { get; set; }
        public virtual string Style { get; set; }
        public virtual string Riderexperience { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual DateTime Modifieddate { get; set; }
    }
}
