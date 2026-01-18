# Factory Design Pattern – Storage Provider Example

This project demonstrates the **Factory Design Pattern** in **C# (.NET Console Application)** using a real-world scenario of **cloud storage providers** such as Amazon S3, Azure Blob Storage, and Google Cloud Storage.

---

## 📌 What is the Factory Design Pattern?

The **Factory Design Pattern** is a creational design pattern that centralizes object creation logic in a single place (the factory), instead of letting the client instantiate objects directly.

The client interacts only with a common interface, while the factory decides **which concrete implementation** to return at runtime.

---

## 🎯 Use Case

In modern applications, files can be stored in different cloud providers depending on:

* Deployment environment
* Cost
* Client preference
* Cloud strategy

Hardcoding storage provider logic in the client makes the system:

* Tightly coupled
* Difficult to extend
* Hard to maintain

---

## ✅ Solution Using Factory Pattern

This project uses:

* An **interface** (`IStorageProvider`) to define storage operations
* Multiple **concrete implementations** for different cloud providers
* A **factory class** (`StorageProviderFactory`) to decide which provider to instantiate

The client code remains unchanged even if new storage providers are added.

---

## 🧱 Project Structure

```
FactoryDesignPattern
│
├── IStorageProvider.cs              // Product interface
├── AmazonS3Provider.cs              // Concrete product
├── AzureBlobProvider.cs             // Concrete product
├── GoogleCloudStorageProvider.cs    // Concrete product
├── StorageProviderFactory.cs        // Factory class
└── Program.cs                       // Client code
```

---

## 🔹 Step-by-Step Explanation

### 1️⃣ Product Interface – `IStorageProvider`

Defines common operations for all storage providers:

* SaveFile
* RetrieveFile

The client works only with this interface.

---

### 2️⃣ Concrete Product Implementations

Each cloud provider implements `IStorageProvider`:

* **AmazonS3Provider**
* **AzureBlobProvider**
* **GoogleCloudStorageProvider**

Each class contains provider-specific logic while following the same contract.

---

### 3️⃣ Factory Class – `StorageProviderFactory`

Responsible for creating storage provider objects based on user input.

```
CreateStorageProvider(string providerName)
```

* Uses a `switch` statement
* Returns an object of type `IStorageProvider`
* Throws an exception for invalid input

The client never uses the `new` keyword for concrete providers.

---

### 4️⃣ Client Code – `Program.cs`

The client:

* Reads provider name from the user
* Requests the provider from the factory
* Uses the provider via the interface

This ensures loose coupling and clean code.

---

## ▶️ Sample Console Output

```
Select your storage provider (AmazonS3, AzureBlob, GoogleCloud):
AmazonS3
Saving sample.txt to Amazon S3...
```

If an invalid provider is entered:

```
Invalid storage provider name
```

---

## ⭐ Advantages of Factory Design Pattern

* Centralized object creation logic
* Loose coupling between client and implementations
* Easy to add new storage providers
* Improves maintainability and scalability
* Supports Open/Closed Principle

---

## ➕ Adding a New Storage Provider

To add a new provider (e.g., `LocalFileSystemProvider`):

1. Create a new class implementing `IStorageProvider`
2. Implement required methods
3. Add a new case in `StorageProviderFactory`
4. No changes required in `Program.cs`

---

## 📌 When to Use This Pattern

* Multiple implementations of the same behavior
* Object creation depends on runtime input
* You want to avoid tight coupling
* You want a clean and testable architecture

---

## 🧠 Key Takeaway

> The Factory Design Pattern allows you to write flexible, scalable, and cloud-agnostic code by hiding object creation details from the client.

---

Happy Coding! 🚀
