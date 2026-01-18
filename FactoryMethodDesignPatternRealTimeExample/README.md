# Factory Method Design Pattern – Report Generator Example

This project demonstrates the **Factory Method Design Pattern** in **C# (.NET Console Application)** using a real-world **report generation** scenario commonly found in analytics and reporting systems.

---

## 📌 What is the Factory Method Design Pattern?

The **Factory Method Design Pattern** is a creational design pattern that defines an interface for creating an object but allows subclasses to decide which class to instantiate.

Unlike the simple Factory pattern, the **Factory Method** relies on **inheritance** and **polymorphism** to delegate object creation to subclasses.

---

## 🎯 Use Case

In analytics systems, reports can be generated in multiple formats such as:

* Chart-based reports
* Tabular reports
* Summary reports

The report type may vary based on:

* User preference
* Business requirement
* Data visualization needs

Hardcoding report creation logic leads to:

* Tight coupling
* Frequent code changes
* Poor scalability

---

## ✅ Solution Using Factory Method Pattern

This implementation introduces:

* A **product interface** (`IReportGenerator`)
* Multiple **concrete products** for each report type
* An **abstract creator** (`ReportGeneratorFactory`)
* Multiple **concrete creators** responsible for instantiating specific products

The client interacts only with the factory abstraction, not concrete implementations.

---

## 🧱 Project Structure

The project is organized to clearly reflect the **Factory Method Design Pattern** roles, making it easy to understand and maintain.

```
FactoryMethodDesignPatternRealTimeExample
│
├── ReportGenerators
│   ├── Factory
│   │   ├── ReportGeneratorFactory.cs              // Abstract Creator
│   │   ├── ChartReportGeneratorFactory.cs         // Concrete Creator
│   │   ├── TabularReportGeneratorFactory.cs       // Concrete Creator
│   │   └── SummaryReportGeneratorFactory.cs       // Concrete Creator
│   │
│   └── Product
│       ├── IReportGenerator.cs                    // Product Interface
│       ├── ChartReportGenerator.cs                // Concrete Product
│       ├── TabularReportGenerator.cs              // Concrete Product
│       └── SummaryReportGenerator.cs              // Concrete Product
│
├── AnalyticsService.cs                            // Client
├── Program.cs                                     // Application entry point
└── README.md                                      // Documentation
```

### Folder Responsibility Overview

* **Product**: Contains the product interface and concrete report implementations
* **Factory**: Contains the abstract factory and concrete factory classes
* **AnalyticsService**: Acts as the client that consumes factories
* **Program.cs**: Demonstrates runtime usage of Factory Method pattern

---

## 🔹 Step-by-Step Explanation

### 1️⃣ Product Interface – `IReportGenerator`

Defines a common contract for all report generators:

* `GenerateReport(string data)`

This allows the client to generate reports without knowing the concrete implementation.

---

### 2️⃣ Concrete Products

Each report type implements `IReportGenerator`:

* **ChartReportGenerator** – Generates chart-based reports
* **TabularReportGenerator** – Generates table-based reports
* **SummaryReportGenerator** – Generates summarized reports

Each class contains its own business logic.

---

### 3️⃣ Creator – `ReportGeneratorFactory`

An abstract class that declares the **factory method**:

```
CreateReportGenerator()
```

This method is overridden by subclasses to create specific report generators.

---

### 4️⃣ Concrete Creators

Each concrete factory decides which report generator to instantiate:

* `ChartReportGeneratorFactory`
* `TabularReportGeneratorFactory`
* `SummaryReportGeneratorFactory`

This enables runtime flexibility using polymorphism.

---

### 5️⃣ Client Code – `AnalyticsService`

The client:

* Accepts a `ReportGeneratorFactory`
* Calls the factory method
* Uses the returned `IReportGenerator`

The client is completely decoupled from concrete classes.

---

## ▶️ Sample Console Output

```
Generating Chart Report with data: ChartData123
Generating Tabular Report with data: TabularData456
Generating Summary Report with data: SummaryData789
```

---

## ⭐ Advantages of Factory Method Pattern

* Promotes loose coupling
* Supports Open/Closed Principle
* Simplifies object creation logic
* Improves scalability and testability
* Encourages clean architecture

---

## ➕ Adding a New Report Type

To add a new report type (e.g., `PdfReportGenerator`):

1. Create a new class implementing `IReportGenerator`
2. Create a corresponding factory extending `ReportGeneratorFactory`
3. No changes required in client code

---

## 📌 When to Use Factory Method Pattern

* Object creation depends on subclasses
* You want to follow SOLID principles
* You want to avoid tight coupling
* You need runtime flexibility

---

## 🧠 Key Takeaway

> Factory Method Pattern delegates object creation to subclasses, enabling extensible and maintainable designs.

---

Happy Coding! 🚀
