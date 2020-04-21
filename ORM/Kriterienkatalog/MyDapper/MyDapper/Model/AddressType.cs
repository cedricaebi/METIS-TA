using System;
using System.Collections.Generic;
using MyDapper.Model;

namespace MyDapper.Model
{
    public partial class AddressType
    {
        public AddressType()
        {
            BusinessEntityAddress = new HashSet<BusinessEntityAddress>();
        }

        public int AddressTypeId { get; set; }
        public string Name { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<BusinessEntityAddress> BusinessEntityAddress { get; set; }
    }
}
