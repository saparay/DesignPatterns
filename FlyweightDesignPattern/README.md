# Flyweight Design Pattern 

## 📌 Overview

This project demonstrates the **Flyweight Design Pattern** in C# using a
simple shape drawing example.

The Flyweight Pattern is used to **reduce memory usage** by sharing
common objects instead of creating new ones repeatedly.

In this example, multiple circles are drawn using **only one shared
object**.

------------------------------------------------------------------------

## 🏗 Project Structure

    FlyweightDesignPattern/
    │
    ├── Program.cs
    ├── ShapeFactory.cs
    ├── Circle.cs
    └── IShape.cs

------------------------------------------------------------------------

## 🎯 Design Pattern Participants

### 1️⃣ Flyweight Interface (IShape)

Defines common operations for flyweight objects.

``` csharp
public interface IShape
{
    void Draw();
}
```

------------------------------------------------------------------------

### 2️⃣ Concrete Flyweight (Circle)

Implements the flyweight interface and stores intrinsic state.

``` csharp
public class Circle : IShape
{
    public string Color { get; set; }

    private readonly int XCor = 10;
    private readonly int YCor = 20;
    private readonly int Radius = 30;
}
```

**Intrinsic State (Shared):** - XCor - YCor - Radius

**Extrinsic State (External):** - Color

------------------------------------------------------------------------

### 3️⃣ Flyweight Factory (ShapeFactory)

Creates and manages shared objects.

``` csharp
private static Dictionary<string, IShape> shapeMap;
```

It checks cache before creating new objects.

------------------------------------------------------------------------

### 4️⃣ Client (Program.cs)

Uses factory to get shapes and sets color.

``` csharp
Circle circle = (Circle)ShapeFactory.GetShape("circle");
circle.SetColor("Red");
circle.Draw();
```

------------------------------------------------------------------------

## 🔄 How It Works

1.  Client requests a shape from `ShapeFactory`.
2.  Factory checks if shape already exists.
3.  If exists → returns cached object.
4.  If not → creates new object and stores it.
5.  Client sets color and draws.

Only **one Circle object** is created and reused.

------------------------------------------------------------------------

## ▶️ Execution Flow

    Request Circle → Factory Cache → Return Same Object
                               ↓
                        Change Color → Draw

------------------------------------------------------------------------

## 📤 Sample Output

    Creating circle object with out any color in shapefactory

    Red color Circles
    Circle: Draw() [Color: Red, X Cor:10, YCor:20, Radius:30]

Only one circle object is created.

------------------------------------------------------------------------

## ✅ Advantages

✔ Reduces memory usage\
✔ Improves performance\
✔ Supports large object creation\
✔ Centralized object management

------------------------------------------------------------------------

## ⚠️ Important Note

In Program.cs, there is a small issue:

``` csharp
// Blue circles are using Green color
circle.SetColor("Green");
```

It should be:

``` csharp
circle.SetColor("Blue");
```

------------------------------------------------------------------------

## 📚 When to Use Flyweight Pattern

Use this pattern when:

-   You have many similar objects
-   Memory optimization is needed
-   Object creation is expensive

Examples: - Text editors (characters) - Game objects - GUI components -
Caching systems

------------------------------------------------------------------------

## 🛠 How to Run

### Using Visual Studio

1.  Create Console App
2.  Add class files
3.  Run project

### Using CLI

``` bash
dotnet new console
dotnet run
```

------------------------------------------------------------------------

## 📊 Pattern Comparison

  Feature   Without Flyweight   With Flyweight
  --------- ------------------- ----------------
  Memory    High                Low
  Objects   Many                Few
  Speed     Normal              Faster
  Cache     No                  Yes

