# Prototype Design Pattern – Shape Cloning (C#)

## 📌 Overview

This example demonstrates the **Prototype Design Pattern** using a **graphics editor scenario**, where shapes (circles) are duplicated efficiently.

Instead of recreating shapes from scratch, the application **clones existing shapes** and then modifies only the required properties (like position).

This is a very common real-world use case in:

* Graphics editors
* Game engines
* UI designers

---

## 🧠 Core Idea

> **Create new objects by copying an existing object (prototype).**

The Prototype pattern allows clients to duplicate objects **without knowing their concrete classes**, improving flexibility and performance.

---

## 🏗️ Project Structure

```
PrototypeDesignPattern
│
├── IShapePrototype.cs   // Prototype Interface
├── Circle.cs            // Concrete Prototype
└── Program.cs           // Client Code
```

---

## 🔹 Components Explained

### 1️⃣ Prototype Interface

```csharp
public interface IShapePrototype
{
    IShapePrototype Clone();
}
```

* Declares a `Clone()` method
* Ensures all shapes support cloning

---

### 2️⃣ Concrete Prototype – Circle

```csharp
public IShapePrototype Clone()
{
    return new Circle
    {
        X = this.X,
        Y = this.Y,
        Radius = this.Radius,
        Color = this.Color
    };
}
```

* Creates a **new Circle instance**
* Copies all properties explicitly
* Safe cloning since properties are value types and immutable strings

---

### 3️⃣ Client Code

```csharp
Circle clonedCircle = (Circle)originalCircle.Clone();
clonedCircle.X = 20;
clonedCircle.Y = 20;
```

* Client works with prototype abstraction
* Original object remains unchanged

---

## ▶️ Execution Flow

1. User creates an original circle
2. Application clones the circle
3. User modifies position of cloned circle
4. Original circle remains intact

---

## 📤 Sample Output

```
Original Circle:
Circle at (5, 5) | Radius: 10 | Color: Red

Cloned Circle with Different Position:
Circle at (20, 20) | Radius: 10 | Color: Red
```

---

## 🧪 Real-World Use Cases

* Graphics and drawing applications
* Game object duplication
* UI component cloning
* CAD software
* Level design tools

---

## ⚠️ Shallow vs Deep Copy

* This example performs a **safe deep copy**
* No reference-type objects that require recursive cloning
* For complex shapes with nested objects, deep cloning logic is required

---

## 🆚 Prototype vs Factory

| Prototype                  | Factory                   |
| -------------------------- | ------------------------- |
| Clones existing objects    | Creates new objects       |
| Preserves object state     | Initializes new state     |
| Faster for complex objects | Better for simple objects |

---

## 🎯 Interview Talking Points

* "Prototype pattern is ideal for object duplication"
* "Used heavily in graphics editors and games"
* "Avoids costly object construction"
* "Clone method controls shallow vs deep copy"

---

## ✅ Advantages

✔ Improves performance
✔ Simplifies object duplication
✔ Reduces constructor complexity
✔ Promotes loose coupling

---

## ❌ Disadvantages

✖ Deep cloning can become complex
✖ Requires careful handling of reference types

---

## ✅ Conclusion

This example shows how the **Prototype Design Pattern** can be used to efficiently clone shapes in a graphics editor-like scenario.

It is a **clean, intuitive, and interview-friendly** implementation of the pattern in C#.

---

📌 *Highly recommended example for explaining Prototype Pattern in interviews and real-world discussions.*
