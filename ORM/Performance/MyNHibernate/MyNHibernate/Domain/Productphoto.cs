using System;
using System.Text;
using System.Collections.Generic;
using Iesi.Collections.Generic;


namespace MyNHibernate.Domain {
    
    public class Productphoto {
        public Productphoto() { }
        public virtual int Productphotoid { get; set; }
        public virtual byte[] Thumbnailphoto { get; set; }
        public virtual string Thumbnailphotofilename { get; set; }
        public virtual byte[] Largephoto { get; set; }
        public virtual string Largephotofilename { get; set; }
        public virtual DateTime Modifieddate { get; set; }
    }
}
