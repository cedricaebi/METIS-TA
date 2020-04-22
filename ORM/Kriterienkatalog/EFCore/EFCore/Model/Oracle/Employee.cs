using System;
using System.Collections.Generic;

namespace EFCore.Model.Oracle
{
    public partial class Employee
    {
        public Employee()
        {
            Customer = new HashSet<Customer>();
            InverseReportstoNavigation = new HashSet<Employee>();
        }

        public decimal Employeeid { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Title { get; set; }
        public decimal? Reportsto { get; set; }
        public DateTime? Birthdate { get; set; }
        public DateTime? Hiredate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Postalcode { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }

        public virtual Employee ReportstoNavigation { get; set; }
        public virtual ICollection<Customer> Customer { get; set; }
        public virtual ICollection<Employee> InverseReportstoNavigation { get; set; }
    }
}
