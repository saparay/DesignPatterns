using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeDesignPattern
{
    public class PermanentEmployee : Employee
    {
        public int Salary { get; set; }
        public override Employee GetClone()
        {
            return (PermanentEmployee)this.MemberwiseClone();
        }

        public override void ShowDetails()
        {
            Console.WriteLine("Permanent Employee");
            Console.WriteLine($"Name: {this.Name}, Department: {this.Department}, Type: {this.Type}, Salary: {this.Salary}\n");
        }
    }
}
