using System;
using System.Collections.Generic;

namespace MyNHibernate.Domain.SQLServer {
    
    public class Employee {
        public Employee() {
			Customer = new List<Customer>();
			Blub = new List<Employee>();
        }
        public virtual int Employeeid { get; set; }
        public virtual Employee EmployeeVal { get; set; }
        public virtual string Lastname { get; set; }
        public virtual string Firstname { get; set; }
        public virtual string Title { get; set; }
        public virtual DateTime? Birthdate { get; set; }
        public virtual DateTime? Hiredate { get; set; }
        public virtual string Address { get; set; }
        public virtual string City { get; set; }
        public virtual string State { get; set; }
        public virtual string Country { get; set; }
        public virtual string Postalcode { get; set; }
        public virtual string Phone { get; set; }
        public virtual string Fax { get; set; }
        public virtual string Email { get; set; }
        public virtual IList<Customer> Customer { get; set; }
        public virtual IList<Employee> Blub { get; set; }
    }
}
