using System;
using System.Collections.Generic;
using System.Text;

namespace ShallowCopyDeepCopyDemo
{
    public class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public Address Address { get; set; }

        public Employee GetShallowCopy()
        {
            Employee employee = (Employee)this.MemberwiseClone();
            return employee;
        }

        public Employee GetDeepCopy()
        {
            Employee employee = (Employee)this.MemberwiseClone();
            employee.Address = Address.GetClone();
            return employee;
        }
    }

    public class Address {
        public string AddressLine { get; set; }

        public Address GetClone()
        {
            Address address = (Address)this.MemberwiseClone();
            return address;
        }
    }
}
