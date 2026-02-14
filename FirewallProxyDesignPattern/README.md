# Firewall Proxy Design Pattern in C

This project demonstrates the **Firewall (Protection) Proxy Design
Pattern** using a document access control example in C#.

------------------------------------------------------------------------

## 📌 Overview

The **Proxy Design Pattern** provides a placeholder object that controls
access to another object.

A **Firewall Proxy** adds a security layer by validating whether a
client is authorized to access a resource.

------------------------------------------------------------------------

## 🏗️ Components

### IDocument (Subject Interface)

Defines the method for reading document content.

### Document (Real Subject)

Stores document content and sensitivity.

### DocumentProxy (Firewall Proxy)

Checks employee access level before allowing access.

### Program (Client)

Interacts with documents via the proxy.

------------------------------------------------------------------------

## 🔐 Access Control Rules

  Sensitivity    Allowed Roles
  -------------- --------------------
  Public         All
  Confidential   Manager, Executive
  Top-Secret     Executive only

------------------------------------------------------------------------

## 🔄 Flow

Client → Proxy (Authorization Check) → Real Document

------------------------------------------------------------------------

## 💻 Example Usage

``` csharp
IDocument doc =
    new DocumentProxy(
        "Confidential document",
        "Confidential",
        "Employee");

Console.WriteLine(doc.ReadContent());
```

------------------------------------------------------------------------

## ✅ Expected Output

    This is a public document.
    Access Denied!
    This is a top-secret document.

------------------------------------------------------------------------

## 🌟 Advantages

-   Strong security enforcement
-   Separation of concerns
-   No modification to real object
-   Easy to extend access rules

------------------------------------------------------------------------

## 🚀 How to Run

1.  Open the project in Visual Studio
2.  Build the solution
3.  Run the application

------------------------------------------------------------------------

## 📚 Design Pattern

**Proxy Design Pattern -- Firewall / Protection Proxy**


