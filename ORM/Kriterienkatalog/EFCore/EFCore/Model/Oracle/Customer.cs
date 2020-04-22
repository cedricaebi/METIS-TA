using System;
using System.Collections.Generic;

namespace EFCore.Model.Oracle
{
    public partial class Customer
    {
        public Customer()
        {
            Invoice = new HashSet<Invoice>();
        }

        public decimal Customerid { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Company { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Postalcode { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public decimal? Supportrepid { get; set; }

        public virtual Employee Supportrep { get; set; }
        public virtual ICollection<Invoice> Invoice { get; set; }
    }
}
