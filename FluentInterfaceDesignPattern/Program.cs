// See https://aka.ms/new-console-template for more information
using FluentInterfaceDesignPattern;

Console.WriteLine("Hello, World!");


FluentEmployee emp = new FluentEmployee();

emp.NameOfEmployee("Naruto Uzumaki")
    .Born("12/12/2000")
    .WorkingOn("Hokage")
    .StaysAt("Leaf Village");

emp.ShowDetails();