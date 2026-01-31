//The Client will use the Facade Interface instead of the Subsystems
using FacadeDesignPattern;

Order order = new Order();
order.PlaceOrder();
Console.Read();