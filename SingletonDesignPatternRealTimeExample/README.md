# Singleton Design Pattern – Database Connection Manager (C#)

## 📌 Overview
This project demonstrates the **Singleton Design Pattern** using a **Database Connection Manager** in C#.  
The goal is to ensure that **only one database connection instance** exists throughout the application lifecycle.

This is a **common interview and real-world example**, especially in backend and enterprise applications.

---

## 🧠 What is the Singleton Pattern?
The Singleton pattern ensures:
- Only **one instance** of a class is created
- A **global access point** to that instance
- Controlled access to shared resources (like DB connections, logging, configuration)

---

## 🏗️ Project Structure
```
SingletonDesignPattern
│
├── DatabaseConnectionManager.cs
└── Program.cs
```

---

## 🔑 Key Components

### 1️⃣ DatabaseConnectionManager (Singleton Class)

```csharp
public class DatabaseConnectionManager
{
    private static readonly DatabaseConnectionManager _instance =
        new DatabaseConnectionManager();

    private SqlConnection _connection;

    private DatabaseConnectionManager()
    {
        _connection = new SqlConnection("YourConnectionStringHere");
    }

    public static DatabaseConnectionManager Instance => _instance;

    public void OpenConnection()
    {
        if (_connection.State == ConnectionState.Closed)
            _connection.Open();
    }

    public void CloseConnection()
    {
        if (_connection.State == ConnectionState.Open)
            _connection.Close();
    }

    public SqlConnection GetConnection()
    {
        return _connection;
    }
}
```

### ✔ Why this works
- `private constructor` prevents `new`
- `static readonly instance` guarantees a single object
- Thread-safe by default (CLR initialization)

---

### 2️⃣ Client Code (Usage)

```csharp
DatabaseConnectionManager.Instance.OpenConnection();

SqlCommand command = new SqlCommand(
    "Your SQL Query Here",
    DatabaseConnectionManager.Instance.GetConnection()
);

// Execute command here...

DatabaseConnectionManager.Instance.CloseConnection();
```

---

## 🧪 Output / Behavior
- Only **one SqlConnection object** is created
- Multiple calls reuse the same connection instance
- Prevents unnecessary resource allocation

---

## ✅ Advantages
- Centralized connection management
- Reduced resource consumption
- Controlled access to database
- Easy to use across the application

---

## ⚠️ Important Notes (Interview Tip)
❌ In **ASP.NET Core**, using Singleton for DB connections is **not recommended**

### Why?
- SQL connections are **not thread-safe**
- Modern apps use **Connection Pooling**
- Recommended approach:
  - Use `IDbConnection` with `using`
  - Let ADO.NET manage pooling

---

## ✅ Real-World Usage
✔ Good for:
- Logging services
- Configuration managers
- Cache providers
- Proxy services

❌ Avoid for:
- Database connections in web apps
- Stateful objects with concurrency risks

---

## 🎯 Interview One-Liner
> “Singleton is used when exactly one object is needed to coordinate actions across the system, such as logging, configuration, or proxy services.”

---

## 🚀 Enhancements You Can Add
- Lazy initialization
- Dependency Injection friendly version
- Connection pooling demo
- Async DB access
- Unit tests

---


**Happy Coding! 🚀**
