# Prototype Design Pattern – Document Versioning (C#)

## 📌 Overview

This project demonstrates the **Prototype Design Pattern** using a **Document versioning** use case.

The Prototype pattern allows you to **clone existing objects** instead of creating new ones from scratch. This is especially useful when:

* Object creation is expensive
* You want to preserve an existing object’s state
* You need multiple variations of the same object

In this example, a `Document` is cloned to create a **new version**, while the original document remains unchanged.

---

## 🧠 Core Concept

> **“Create new objects by copying existing ones.”**

Rather than using constructors repeatedly, the Prototype pattern provides a `Clone()` method that duplicates the object.

---

## 🏗️ Project Structure

```
PrototypeDesignPattern
│
├── IDocumentPrototype.cs   // Prototype Interface
├── Document.cs             // Concrete Prototype
└── Program.cs              // Client Code
```

---

## 🔹 Components Explained

### 1️⃣ Prototype Interface

```csharp
public interface IDocumentPrototype
{
    IDocumentPrototype Clone();
}
```

* Declares the `Clone()` method
* Ensures all prototypes support cloning

---

### 2️⃣ Concrete Prototype – Document

```csharp
public IDocumentPrototype Clone()
{
    return new Document
    {
        Title = this.Title,
        Content = this.Content
    };
}
```

* Creates a **new Document instance**
* Copies properties explicitly (safe deep copy for strings)
* Strings are immutable, so no reference-sharing issues

---

### 3️⃣ Client Code

```csharp
Document versionedDoc = (Document)originalDoc.Clone();
versionedDoc.Content += "\nUpdated content";
```

* Client does not depend on concrete constructors
* Original object remains unchanged

---

## ▶️ Execution Flow

1. Create an original `Document`
2. Clone it using `Clone()`
3. Modify the cloned document
4. Preserve the original document state

---

## 📤 Sample Output

```
Original Document:
Title: Prototype Design Pattern
Content: This is a document explaining the prototype design pattern.

Versioned Document:
Title: Prototype Design Pattern
Content: This is a document explaining the prototype design pattern.
Now, the content has been updated to include more details.
```

---

## 🧪 Real-World Use Cases

* Document versioning systems
* Content management systems (CMS)
* Report templates
* Configuration snapshots
* Undo/Redo functionality

---

## ⚠️ Shallow vs Deep Copy

* This example performs a **safe deep copy**
* Strings are immutable, so copying references is safe
* For complex reference types, manual cloning is required

---

## 🆚 Prototype vs Factory

| Prototype                  | Factory                    |
| -------------------------- | -------------------------- |
| Clones existing objects    | Creates new objects        |
| Preserves object state     | Initializes fresh state    |
| Faster for complex objects | Better for simple creation |

---

## 🎯 Interview Talking Points

* "Prototype pattern is used to clone objects instead of instantiating them"
* "It reduces object creation cost"
* "Useful for versioning and templates"
* "Clone implementation decides shallow vs deep copy"

---

## ✅ Advantages

✔ Avoids costly object creation
✔ Simplifies object duplication
✔ Promotes loose coupling
✔ Easy to extend with new prototype types

---

## ❌ Disadvantages

✖ Deep cloning can be complex
✖ Requires careful handling of references

---

## ✅ Conclusion

This example shows how the **Prototype Design Pattern** can be used for **document versioning**, ensuring immutability of the original object while allowing efficient creation of modified copies.

A clean, simple, and interview-ready implementation in C#.

---

📌 *Recommended for design pattern learning, interviews, and real-world enterprise applications.*
