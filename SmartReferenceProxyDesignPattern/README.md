# Smart Reference Proxy Design Pattern in C

This project demonstrates the **Smart Reference Proxy Design Pattern**
using a database connection pool example in C#.

------------------------------------------------------------------------

## 📌 Overview

The **Proxy Design Pattern** provides a placeholder object that controls
access to another object.

A **Smart Reference Proxy** adds extra behavior when accessing an
object, such as:

-   Resource management
-   Connection pooling
-   Health checks
-   Performance optimization

------------------------------------------------------------------------

## 🏗️ Components

### IDatabaseConnection (Subject Interface)

Defines the method for executing database queries.

### DatabaseConnection (Real Subject)

Executes actual database queries.

### DatabaseConnectionProxy (Smart Proxy)

Manages connection pool and validates connection health.

### Program (Client)

Uses the proxy for database access.

------------------------------------------------------------------------

## 🔄 Connection Management

-   Maintains a pool of reusable connections
-   Fetches available connection
-   Executes query
-   Returns connection to pool
-   Replaces unhealthy connections

------------------------------------------------------------------------

## 💻 Example Usage

``` csharp
IDatabaseConnection connection = new DatabaseConnectionProxy();
connection.ExecuteQuery("SELECT * FROM users");
```

------------------------------------------------------------------------

## ✅ Output Example

    Proxy: Checking connection health...
    Executing query: SELECT * FROM users

------------------------------------------------------------------------

## 🌟 Advantages

-   Efficient resource utilization
-   Automatic connection reuse
-   Centralized monitoring
-   Reduced memory overhead

------------------------------------------------------------------------

## ⚠️ Limitations

-   More complex implementation
-   Requires thread safety in real systems

------------------------------------------------------------------------

## 🚀 How to Run

1.  Open in Visual Studio
2.  Build project
3.  Run application

------------------------------------------------------------------------

## 📚 Design Pattern

**Proxy Design Pattern -- Smart Reference Proxy**

