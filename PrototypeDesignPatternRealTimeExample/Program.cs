using PrototypeDesignPatternRealTimeExample.DocumentVersioningSystem;
using PrototypeDesignPatternRealTimeExample.GraphicsEditors;

Document originalDoc = new Document
{
    Title = "Prototype Design Pattern",
    Content = "This is a document explaining the prototype design pattern."
};

Console.WriteLine("Original Document:");
originalDoc.Display();


Document versionedDoc = (Document)originalDoc.Clone();

versionedDoc.Content += "\nNow, the content has been updated to include more details.";

Console.WriteLine("Versioned Document:");
versionedDoc.Display();

Console.ReadKey();


//Graphics Editors

Circle originalCircle = new Circle
{
    X = 5,
    Y = 5,
    Radius = 10,
    Color = "Red"
};
Console.WriteLine("Original Circle:");
originalCircle.Display();

Circle clonedCircle = (Circle)originalCircle.Clone();
clonedCircle.X = 20;
clonedCircle.Y = 20;
Console.WriteLine("Cloned Circle with Different Position:");
clonedCircle.Display();
Console.ReadKey();

