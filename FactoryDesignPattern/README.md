# Factory Design Pattern – Credit Card Example

This project demonstrates the **Factory Design Pattern** in **C# (.NET Console Application)** using a real-world example of creating different types of credit cards.

---

## 📌 What is the Factory Design Pattern?

The **Factory Design Pattern** is a creational design pattern that provides an interface for creating objects but allows subclasses or a factory class to decide which class to instantiate.

Instead of creating objects directly using the `new` keyword, the client code requests objects from a **factory**, which encapsulates the object creation logic.

---

## 🎯 Problem Statement

In a credit card system, we may have multiple card types such as:

* MoneyBack
* Titanium
* Platinum

Each card type has different:

* Credit limit
* Annual charge

If object creation logic is handled directly in the `Main` method, the code becomes:

* Tightly coupled
* Difficult to extend
* Hard to maintain

---

## ✅ Solution Using Factory Pattern

We use:

* An **interface** (`ICreditCard`) to define common behavior
* **Concrete classes** (`MoneyBack`, `Titanium`, `Platinum`) that implement the interface
* A **factory class** (`CreditCardFactory`) that decides which object to create based on input

This approach makes the system:

* Loosely coupled
* Easy to extend
* Easy to maintain

---

## 🧱 Project Structure

```
FactoryDesignPattern
│
├── Program.cs                // Client code
├── ICreditCard.cs            // Interface
├── MoneyBack.cs              // Concrete class
├── Titanium.cs               // Concrete class
├── Platinum.cs               // Concrete class
└── CreditCardFactory.cs      // Factory class
```

---

## 🔹 Step-by-Step Explanation

### 1️⃣ ICreditCard Interface

Defines a contract that all credit card types must follow.

Responsibilities:

* Provide card type
* Provide credit limit
* Provide annual charge

---

### 2️⃣ Concrete Credit Card Classes

Each class implements `ICreditCard` and provides its own values:

* **MoneyBack**
* **Titanium**
* **Platinum**

These classes contain **only business logic**, not creation logic.

---

### 3️⃣ CreditCardFactory

The factory class contains a static method:

```
GetCreditCard(string cardType)
```

Based on the input string, it:

* Creates the appropriate credit card object
* Returns it as `ICreditCard`

The client does not know which concrete class is created.

---

### 4️⃣ Client Code (Program.cs)

The client:

* Calls the factory
* Works only with the interface (`ICreditCard`)
* Never uses `new` for concrete classes

This keeps the client code clean and loosely coupled.

---

## ▶️ Sample Output

When input is `"Platinum"`:

```
CardType : Platinum Plus
CreditLimit : 35000
AnnualCharge : 2000
```

If an invalid card type is passed:

```
Invalid Card Type
```

---

## ⭐ Advantages of Factory Design Pattern

* Loose coupling between client and object creation
* Single Responsibility Principle (creation logic is centralized)
* Open/Closed Principle (easy to add new card types)
* Improves maintainability and scalability

---

## ➕ How to Add a New Credit Card Type

1. Create a new class implementing `ICreditCard`
2. Add the new condition in `CreditCardFactory`
3. No changes required in `Program.cs`

---

## 📌 When to Use Factory Pattern

* When object creation logic is complex
* When the system should be easily extendable
* When client code should not depend on concrete classes

---

## 🧠 Key Takeaway

> The Factory Design Pattern hides object creation logic and provides a clean, maintainable, and scalable architecture.

---

Happy Coding! 🚀
