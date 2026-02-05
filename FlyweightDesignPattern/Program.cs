using FlyweightDesignPattern;

Console.WriteLine("\n Red color Circles ");
for (int i = 0; i < 3; i++)
{
    Circle circle = (Circle)ShapeFactory.GetShape("circle");
    circle.SetColor("Red");
    circle.Draw();
}

Console.WriteLine("\n Green color Circles ");
for (int i = 0; i < 3; i++)
{
    Circle circle = (Circle)ShapeFactory.GetShape("circle");
    circle.SetColor("Green");
    circle.Draw();
}
//Creating Circle Objects with Blue Color
Console.WriteLine("\n Blue color Circles");
for (int i = 0; i < 3; ++i)
{
    Circle circle = (Circle)ShapeFactory.GetShape("circle");
    circle.SetColor("Green");
    circle.Draw();
}
//Creating Circle Objects with Orange Color
Console.WriteLine("\n Orange color Circles");
for (int i = 0; i < 3; ++i)
{
    Circle circle = (Circle)ShapeFactory.GetShape("circle");
    circle.SetColor("Orange");
    circle.Draw();
}
//Creating Circle Objects with Black Color
Console.WriteLine("\n Black color Circles");
for (int i = 0; i < 3; ++i)
{
    Circle circle = (Circle)ShapeFactory.GetShape("circle");
    circle.SetColor("Black");
    circle.Draw();
}
Console.ReadKey();
