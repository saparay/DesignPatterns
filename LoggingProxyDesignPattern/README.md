# Logging Proxy Design Pattern in C

This project demonstrates the **Logging Proxy Design Pattern** using a
simple banking system example in C#.

------------------------------------------------------------------------

## 📌 Overview

The Proxy Pattern provides a surrogate or placeholder for another object
to control access to it.

In this example, a **Logging Proxy** is used to:

-   Intercept banking operations
-   Log transactions
-   Forward calls to the real service

------------------------------------------------------------------------

## 🏗️ Project Structure

### 1. IBankingOperation (Subject Interface)

Defines banking operations.

### 2. BankingService (Real Subject)

Performs the actual fund transfer.

### 3. LoggingBankingProxy (Proxy)

Logs actions before and after calling the real service.

### 4. ILogger (Logger Interface)

Defines logging behavior.

### 5. ConsoleLogger (Concrete Logger)

Logs messages to the console.

### 6. Program (Client)

Uses the proxy instead of directly accessing the service.

------------------------------------------------------------------------

## 🔄 Flow Diagram

Client\
↓\
Logging Proxy\
↓\
Real Service

------------------------------------------------------------------------

## 💻 Sample Code

``` csharp
IBankingOperation bankingService = new BankingService();
ILogger logger = new ConsoleLogger();

IBankingOperation proxyBankingService =
    new LoggingBankingProxy(bankingService, logger);

proxyBankingService.TransferFunds("A", "B", 1000m);
```

------------------------------------------------------------------------

## ✅ Output Example

    LOG: Initiating transfer of ₹1,000.00 from AccountA to AccountB.
    Transferred ₹1,000.00 from AccountA to AccountB.
    LOG: Transfer completed.

------------------------------------------------------------------------

## 🌟 Benefits

-   Separation of concerns
-   Easy logging implementation
-   No changes to core logic
-   Follows Open/Closed Principle

------------------------------------------------------------------------

## 🚀 How to Run

1.  Open the project in Visual Studio
2.  Build the solution
3.  Run the application
4.  View logs in console

------------------------------------------------------------------------

## 📚 Design Pattern Used

**Proxy Design Pattern (Structural Pattern)**



