using FluentInterfaceDesignPatternRealTimeExample.AutomapperExample;

var customer = new Customer { FirstName = "John", LastName = "Doe" };

//Initializing AutoMapper
var mapper = MapperConfig.InitializeAutomapper();
//Way1: Specify the Destination Type and to The Map Method pass the Source Object
var customerDTO1 = mapper.Map<CustomerDTO>(customer);
Console.WriteLine(customerDTO1.FullName); // Outputs: John Doe
                                          //Way2: Specify the both Source and Destination Type 
                                          //and to The Map Method pass the Source Object
var customerDTO2 = mapper.Map<Customer, CustomerDTO>(customer);
Console.WriteLine(customerDTO2.FullName); // Outputs: John Doe

Console.ReadKey();