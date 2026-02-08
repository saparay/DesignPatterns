# Proxy Design Pattern -- Shared Folder Example in C

## 📌 Overview

This project demonstrates the **Proxy Design Pattern** in C# using a
**Shared Folder Access Control** example.

The Proxy Pattern provides a **surrogate or placeholder** for another
object to control access to it.

In this example, a proxy controls access to a shared folder based on the
employee's role.

------------------------------------------------------------------------

## 🏗 Project Structure

    ProxyDesignPattern/
    │
    ├── Employee.cs
    ├── ISharedFolder.cs
    ├── SharedFolder.cs
    ├── SharedFolderProxy.cs
    └── Program.cs

------------------------------------------------------------------------

## 🎯 Design Pattern Participants

### 1️⃣ Subject Interface (ISharedFolder)

Defines common operations for RealSubject and Proxy.

``` csharp
public interface ISharedFolder
{
    void PerformRWOperations();
}
```

------------------------------------------------------------------------

### 2️⃣ Real Subject (SharedFolder)

Contains the actual business logic.

``` csharp
public class SharedFolder : ISharedFolder
{
    public void PerformRWOperations()
    {
        Console.WriteLine("Performing Read Write operation");
    }
}
```

------------------------------------------------------------------------

### 3️⃣ Proxy (SharedFolderProxy)

Controls access to the real object.

``` csharp
class SharedFolderProxy : ISharedFolder
{
    private ISharedFolder folder;
    private Employee employee;
}
```

Checks user role before granting access.

------------------------------------------------------------------------

### 4️⃣ Client (Program.cs)

Uses the proxy instead of accessing the real object directly.

``` csharp
Employee emp = new Employee("Anurag", "123", "Developer");
SharedFolderProxy proxy = new SharedFolderProxy(emp);
proxy.PerformRWOperations();
```

------------------------------------------------------------------------

## 🔄 How It Works

1.  Client creates an Employee object.
2.  Client passes Employee to Proxy.
3.  Proxy checks employee role.
4.  If role is allowed → calls RealSubject.
5.  If not → denies access.

------------------------------------------------------------------------

## ▶️ Execution Flow

    Client → Proxy → (Access Check) → RealSubject → Shared Folder
                  ↓
             Access Denied

------------------------------------------------------------------------

## 📤 Sample Output

    Client passing employee with Role Developer to folderproxy
    Shared Folder proxy says 'You don't have permission to access this folder'

    Client passing employee with Role Manager to folderproxy
    Shared Folder Proxy makes call to the RealFolder
    Performing Read Write operation on the Shared Folder

------------------------------------------------------------------------

## ✅ Advantages

✔ Controls access to sensitive objects\
✔ Improves security\
✔ Supports lazy loading\
✔ Adds logging and monitoring\
✔ Follows Open/Closed Principle

------------------------------------------------------------------------

## ⚠️ Important Notes

### 1. Role Validation

Currently, only these roles are allowed:

``` csharp
CEO
MANAGER
```

You can extend this using enums or role lists.

### 2. Password Usage

Password is not used in validation.\
For real applications, integrate authentication.

------------------------------------------------------------------------

## 📚 Types of Proxy

This example demonstrates **Protection Proxy**.

Other types include:

-   Virtual Proxy (lazy loading)
-   Remote Proxy (remote services)
-   Caching Proxy
-   Logging Proxy

------------------------------------------------------------------------

## 📚 When to Use Proxy Pattern

Use this pattern when:

-   You need access control
-   You want lazy initialization
-   You want monitoring/logging
-   You need to wrap expensive objects

Examples: - Database connections - File systems - APIs - Security layers

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

## 📈 Real-World Use Case

✔ Secure file systems\
✔ API gateways\
✔ Firewall systems\
✔ Cloud storage access
