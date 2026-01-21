# Builder Design Pattern – Custom String Builder Example

This project demonstrates the **Builder Design Pattern** in **C# (.NET Console Application)** using a practical example of building a complex string step by step.

---

## 📌 What is the Builder Design Pattern?

The **Builder Design Pattern** is a creational design pattern that allows you to construct a complex object **incrementally**, separating the construction process from the final representation.

It is especially useful when:

* An object requires multiple steps to be created
* You want a fluent, readable API
* Object construction logic should be isolated

---

## 🎯 Real-World Use Case

In real-world applications, we often need to:

* Build formatted strings
* Create SQL queries
* Generate reports or documents
* Construct complex objects with optional parts

Directly managing string concatenation can lead to:

* Poor readability
* Inefficient performance
* Hard-to-maintain code

---

## ✅ Solution Using Builder Pattern

This example introduces:

* A **Product** (`CustomString`) that represents the final object
* A **Builder** (`StringConstructor`) that provides step-by-step construction
* A **fluent interface** to improve readability

The client constructs the object without worrying about its internal representation.

---

## 🧱 Project Structure

```
BuilderDesignPattern
│
├── CustomString.cs          // Product
├── StringConstructor.cs    // Builder
├── Program.cs              // Client code
└── README.md               // Documentation
```

---

## 🔹 Step-by-Step Explanation

### 1️⃣ Product – `CustomString`

* Holds the final string
* Uses `StringBuilder` internally for efficiency
* Exposes only the required behavior

---

### 2️⃣ Builder – `StringConstructor`

Provides methods to construct the string step by step:

* `AppendLine(string line)`
* `AppendSpace(string word)`
* `AppendWords(params string[] words)`
* `Build()`

Each method returns the builder itself, enabling **method chaining**.

---

### 3️⃣ Client Code – `Program.cs`

The client:

* Uses the builder to append content
* Calls `Build()` to get the final object
* Never directly manipulates `CustomString`

This keeps object construction clean and readable.

---

## ▶️ Sample Console Output

```
Hello, Builder pattern!
This is a custom string builder! 
It's efficient.
```

---

## ⭐ Advantages of Builder Design Pattern

* Improves code readability
* Separates construction logic from representation
* Supports fluent APIs
* Avoids large constructors
* Makes object creation flexible and maintainable

---

## ➕ Extending the Builder

You can easily extend this builder by adding methods such as:

* `AppendComma(string value)`
* `AppendTab(string value)`
* `AppendUpperCase(string value)`

No changes are required in client code.

---

## 🆚 Builder vs Factory

| Builder Pattern               | Factory Pattern             |
| ----------------------------- | --------------------------- |
| Builds objects step-by-step   | Creates objects in one step |
| Focus on construction process | Focus on object creation    |
| Ideal for complex objects     | Ideal for simple objects    |

---

## 🧠 Key Takeaway

> The Builder Design Pattern is ideal when creating complex objects incrementally while keeping the construction process readable and flexible.

---

Happy Coding! 🚀
