# Singleton Design Pattern (C#)

## 📌 Overview

The **Singleton Design Pattern** is a **creational design pattern** that ensures **only one instance of a class exists** throughout the application and provides a **global access point** to that instance.

This example demonstrates a **basic Singleton implementation in C#**, focusing on:

* Private constructor
* Static instance
* Lazy initialization

⚠️ **Note:** This implementation is **not thread-safe** and is intended for learning purposes.

---

## 🧠 Key Concept

> **"One class, one instance, global access."**

The Singleton pattern prevents multiple objects of the same class from being created.

---

## 🏗️ Project Structure

```
SingletonDesignPattern
│
├── Singleton.cs   // Singleton Class
└── Program.cs     // Client Code
```

---

## 🔹 Singleton Class Explained

### 1️⃣ Private Static Instance

```csharp
private static Singleton Instance = null;
```

* Holds the single instance of the class
* Shared across the entire application

---

### 2️⃣ Private Constructor

```csharp
private Singleton()
{
    Counter++;
    Console.WriteLine("Counter Value " + Counter);
}
```

* Prevents external instantiation using `new`
* Counter proves constructor is called only once

---

### 3️⃣ Global Access Method

```csharp
public static Singleton GetInstance()
{
    if (Instance == null)
    {
        Instance = new Singleton();
    }
    return Instance;
}
```

* Creates the instance only when needed (lazy initialization)
* Returns the same instance on every call

---

## ▶️ Execution Flow

1. First call to `GetInstance()` → instance created
2. Constructor executes and increments counter
3. Second call to `GetInstance()` → same instance returned
4. Constructor is **not called again**

---

## 📤 Sample Output

```
Counter Value 1
From Teacher
From Student
```

✔ Confirms only **one instance** was created

---

## 🧪 Real-World Use Cases

* Logging services
* Configuration managers
* Caching services
* Database connection managers
* Application state management

---

## ❌ Limitations of This Implementation

| Issue             | Explanation                                    |
| ----------------- | ---------------------------------------------- |
| Not thread-safe   | Multiple threads can create multiple instances |
| Hard to unit test | Global state introduces tight coupling         |
| No lazy safety    | Needs synchronization in multi-threaded apps   |

---

## ✅ Thread-Safe Alternatives (Recommended)

* `Lazy<T>` Singleton
* Double-check locking
* Static initialization

Example (Lazy<T>):

```csharp
public static readonly Lazy<Singleton> instance =
    new Lazy<Singleton>(() => new Singleton());
```

---

## 🆚 Singleton vs Static Class

| Singleton                | Static Class                |
| ------------------------ | --------------------------- |
| Can implement interfaces | Cannot implement interfaces |
| Can be lazy-loaded       | Loaded at startup           |
| Supports inheritance     | No inheritance              |

---

## 🎯 Interview Talking Points

* "Singleton ensures a single instance across the application"
* "Constructor must be private"
* "Lazy initialization improves performance"
* "Thread safety is critical in real systems"
* "Overusing Singleton can lead to tight coupling"

---

## ✅ Conclusion

This example shows a **basic Singleton implementation** in C# and clearly demonstrates how a single instance is maintained.

For production systems, always prefer **thread-safe Singleton implementations**.

---

📌 *Recommended for interviews, learning design patterns, and understanding object lifecycle management in C#.*
