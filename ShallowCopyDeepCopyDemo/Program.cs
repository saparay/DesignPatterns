//Example to Understand Deep Copy and Shallow Copy in C#
//Creating Employee Object
using ShallowCopyDeepCopyDemo;

Employee emp1 = new Employee
{
    Name = "Anurag",
    Department = "IT",
    Address = new Address() { AddressLine = "BBSR" }
};
//Creating a Clone Object from the Existing Object using the GetDeepCopy method
Employee emp2 = emp1.GetDeepCopy();
//Changing Name and Address Property of Clone Object
emp2.Name = "Pranaya";
emp2.Address.AddressLine = "Mumbai";
Console.WriteLine("Using Deep Copy");
Console.WriteLine($" Emplpyee 1: Name: {emp1.Name}, Address: {emp1.Address.AddressLine}");
Console.WriteLine($" Emplpyee 2: Name: {emp2.Name}, Address: {emp2.Address.AddressLine}");
//Creating Employee Object
Employee emp3 = new Employee
{
    Name = "Sambit",
    Department = "HR",
    Address = new Address() { AddressLine = "Delhi" }
};
//Creating a Clone Object from the Existing Object using the GetShallowCopy method
Employee emp4 = emp3.GetShallowCopy();
//Changing Name and Address Property of Clone Object
emp4.Name = "Hina";
emp4.Address.AddressLine = "Hyderabad";
Console.WriteLine("\nUsing Shallow Copy");
Console.WriteLine($" Emplpyee 3: Name: {emp3.Name}, Address: {emp3.Address.AddressLine}");
Console.WriteLine($" Emplpyee 4: Name: {emp4.Name}, Address: {emp4.Address.AddressLine}");

Console.Read();