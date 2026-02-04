# Composite Design Pattern in C#

This repository contains a simple and clean implementation of the **Composite Design Pattern** using C#. The project demonstrates how to treat individual objects (Leaf) and compositions of objects (Composite) uniformly through a common interface.

---

## 🏗️ Design Overview

The Composite Design Pattern is a structural pattern used to represent part-whole hierarchies. It allows clients to treat individual objects and compositions of objects identically.

[Image of composite design pattern diagram]

### Core Components
1. **IComponent (Interface):** The base interface that defines the common operation (`DisplayPrice`) for both simple and complex objects.
2. **Leaf (Object):** Represents the end-objects of the composition. A leaf has no children. (e.g., RAM, CPU, Mouse).
3. **Composite (Container):** Represents complex components that may have children. It implements the methods defined in the interface and delegates the work to its children.

---

## 💻 Code Structure

### 1. The Interface (`IComponent.cs`)
Defines the contract for all components in the tree.
```csharp
public interface IComponent
{
    void DisplayPrice();
}
```

### 2. The Leaf Class (`Leaf.cs`)
Represents individual hardware components with a specific price.
```csharp
public class Leaf : IComponent
{
    public int Price { get; set; }
    public string Name { get; set; }
    // ... Constructor and DisplayPrice implementation
}
```

### 3. The Composite Class (`Composite.cs`)
A container that holds a list of `IComponent` objects. When `DisplayPrice()` is called, it iterates through all its children.
```csharp
public class Composite : IComponent
{
    List<IComponent> components = new List<IComponent>();
    public void AddComponent(IComponent component) { ... }
    // ...
}
```

---

## 🚀 How It Works

In this example, we build a "Computer" hierarchy:
* **Computer** (Composite)
    * **Cabinet** (Composite)
        * **Motherboard** (Composite)
            * CPU (Leaf)
            * RAM (Leaf)
        * Hard Disk (Leaf)
    * **Peripherals** (Composite)
        * Mouse (Leaf)
        * Keyboard (Leaf)

Calling `computer.DisplayPrice()` will recursively trigger the display of every single component's price in the entire tree.

---

## 🛠️ Requirements
* .NET SDK (6.0 or later recommended)
* A C# IDE (Visual Studio, VS Code, or JetBrains Rider)

## 🏃 Execution
1. Clone the repository.
2. Navigate to the project folder.
3. Run the following command:
   ```bash
   dotnet run
   ```
