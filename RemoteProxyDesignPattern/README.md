# Remote Proxy Design Pattern -- User Service Example in C

## 📌 Overview

This project demonstrates the **Remote Proxy Design Pattern** in C#
using a **User Service** example.

A Remote Proxy represents an object that resides in a different address
space (remote server) and provides a local interface for clients to
interact with it.

In this example, the proxy simulates communication with a remote user
service.

------------------------------------------------------------------------

## 🏗 Project Structure

    RemoteProxyDesignPattern/
    │
    ├── Program.cs
    ├── IUserService.cs
    ├── RealUserService.cs
    └── RemoteUserServiceProxy.cs

------------------------------------------------------------------------

## 🎯 Design Pattern Participants

### 1️⃣ Subject Interface (IUserService)

Defines common operations for RealSubject and Proxy.

``` csharp
public interface IUserService
{
    string GetUserName(int userId);
}
```

------------------------------------------------------------------------

### 2️⃣ Real Subject (RealUserService)

Implements the actual business logic.

``` csharp
public class RealUserService : IUserService
{
    public string GetUserName(int userId)
    {
        return $"User_{userId}";
    }
}
```

------------------------------------------------------------------------

### 3️⃣ Remote Proxy (RemoteUserServiceProxy)

Acts as a local representative for the remote service.

``` csharp
public class RemoteUserServiceProxy : IUserService
{
    public string GetUserName(int userId)
    {
        return RemoteMethodCall(userId);
    }
}
```

------------------------------------------------------------------------

### 4️⃣ Client (Program.cs)

Uses the proxy instead of directly accessing the real service.

``` csharp
IUserService userService = new RemoteUserServiceProxy();
string userName = userService.GetUserName(1);
```

------------------------------------------------------------------------

## 🔄 How It Works

1.  Client requests user data through IUserService.
2.  Proxy receives the request.
3.  Proxy performs a simulated remote call.
4.  Proxy communicates with RealUserService.
5.  Result is returned to client.

------------------------------------------------------------------------

## ▶️ Execution Flow

    Client → Remote Proxy → (Network Call Simulation) → Real Service
                                      ↓
                                 Return Result

------------------------------------------------------------------------

## 📤 Sample Output

    Received username: User_1

------------------------------------------------------------------------

## ✅ Advantages

✔ Hides networking complexity\
✔ Improves code maintainability\
✔ Supports distributed systems\
✔ Enhances scalability\
✔ Separates client from server

------------------------------------------------------------------------

## ⚠️ Important Notes

### 1. Simulation Only

This example simulates remote calls locally.

In real applications, use: - REST APIs - gRPC - WCF - Web Services

### 2. Error Handling

Real-world remote proxies should handle: - Network failures - Timeouts -
Authentication - Serialization

------------------------------------------------------------------------

## 📚 Types of Proxy

This example demonstrates **Remote Proxy**.

Other types include:

-   Virtual Proxy
-   Protection Proxy
-   Caching Proxy
-   Logging Proxy

------------------------------------------------------------------------

## 📚 When to Use Remote Proxy

Use this pattern when:

-   Services run on different machines
-   You build distributed systems
-   You need transparent remote access

Examples: - Microservices - Cloud APIs - Web services - Distributed
databases

------------------------------------------------------------------------

## 🛠 How to Run

### Using Visual Studio

1.  Create Console App
2.  Add all class files
3.  Run project

### Using CLI

``` bash
dotnet new console
dotnet run
```

------------------------------------------------------------------------

## 📈 Real-World Mapping

  This Example             Real System
  ------------------------ ---------------------
  RemoteUserServiceProxy   API Client
  RealUserService          Microservice
  IUserService             Service Contract
  Program                  Frontend / Consumer

