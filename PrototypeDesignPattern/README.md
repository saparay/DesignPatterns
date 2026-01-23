# Prototype Design Pattern (C#)

## 📌 Overview

The **Prototype Design Pattern** is a **creational design pattern** that allows you to create new objects by **cloning existing objects**, rather than instantiating them from scratch.

This pattern is useful when:

* Object creation is **costly or complex**
* You want to avoid repeated initialization logic
* You need copies of objects with **minor variations**

In this project, we demonstrate the Prototype pattern using **Employee objects** (Permanent and Temporary employees).

---

## 🧠 Key Idea

Instead of creating new objects using `new`, we:

1. Create a **prototype object**
2. Clone it using a `GetClone()` method
3. Modify only the required properties

---

## 🏗️ Project Structure

```
PrototypeDesignPattern
│
├── Employee.cs              // Abstract Prototype
├── PermanentEmployee.cs     // Concrete Prototype
├── TemporaryEmployee.cs     // Concrete Prototype
└── Program.cs               // Client Code
```

---

## 🔹 Components Explained

### 1️⃣ Prototype (Abstract Class)

```csharp
public abstract class Employee
{
    public string Name { get; set; }
    public string Department { get; set; }
    public string Type { get; set; }

    public abstract Employee GetClone();
    public abstract void ShowDetails();
}
```

* Declares the cloning method `GetClone()`
* Ensures all derived classes support cloning

---

### 2️⃣ Concrete Prototype – PermanentEmployee

```csharp
public override Employee GetClone()
{
    return (PermanentEmployee)this.MemberwiseClone();
}
```

* Uses `MemberwiseClone()` for **shallow copy**
* Copies all value-type fields and references

---

### 3️⃣ Concrete Prototype – TemporaryEmployee

```csharp
public override Employee GetClone()
{
    return (TemporaryEmployee)this.MemberwiseClone();
}
```

* Same cloning mechanism, different object type

---

### 4️⃣ Client Code

```csharp
Employee emp2 = emp1.GetClone();
emp2.Name = "Pranaya";
emp2.Department = "HR";
```

* Client does **not care about concrete class**
* Works with base `Employee` type

---

## ▶️ Execution Flow

1. Create an original Employee object
2. Call `GetClone()` to duplicate it
3. Modify cloned object properties
4. Original object remains unchanged

---

## 🧪 Sample Output

```
Permanent Employee
 Name: Anurag, Department: IT, Type: Permanent, Salary: 100000

Permanent Employee
 Name: Pranaya, Department: HR, Type: Permanent, Salary: 100000

Temporary Employee
 Name: Preety, Department: HR, Type: Temporary, FixedAmount: 200000

Temporary Employee
 Name: Priyanka, Department: Sales, Type: Temporary, FixedAmount: 200000
```

---

## ⚠️ Shallow vs Deep Copy

### 🔹 Shallow Copy (Used Here)

* Copies value types
* Copies references (not referenced objects)
* Fast and memory-efficient

### 🔹 Deep Copy

* Copies entire object graph
* Required when objects contain nested reference types

---

## 💡 Real-World Use Cases

* Employee templates in HR systems
* Game characters cloning
* Configuration objects
* Report or document templates
* Cache-based object creation

---

## 🎯 Advantages

✔ Improves performance
✔ Reduces object creation complexity
✔ Promotes loose coupling
✔ Easy to add new prototype types

---

## ❌ Disadvantages

✖ Deep cloning can be complex
✖ Care needed with reference-type fields

---

## 🆚 Prototype vs Factory

| Prototype                  | Factory                    |
| -------------------------- | -------------------------- |
| Clones existing objects    | Creates new objects        |
| Faster for complex objects | Better for simple creation |
| Preserves state            | Initializes from scratch   |

---

## 🗣️ Interview Talking Points

* "Prototype pattern is used when object creation is expensive"
* "It allows cloning without coupling client to concrete classes"
* "MemberwiseClone provides shallow copy"
* "Used when many similar objects are required"

---

## ✅ Conclusion

The **Prototype Design Pattern** is a powerful way to optimize object creation by cloning existing instances. This example demonstrates a clean, extensible, and interview-ready implementation using C#.

---

📌 **Recommended for:** Senior .NET interviews, system design discussions, and real-world enterprise applications.
