# Decorator Design Pattern – C# Example

## 📌 Overview
This project demonstrates the **Decorator Design Pattern** using a real-world car manufacturing example in **C#**.

The Decorator Pattern allows you to **add new behavior to objects dynamically** without modifying their existing code.  
In this example, we add **Petrol** or **Diesel engines** to a `BMWCar` at runtime.

---

## 🧠 Problem Statement
- We have a base car (`BMWCar`) without an engine.
- We want to add different engine types (Petrol / Diesel).
- We should not modify the existing `BMWCar` class for every new engine type.

✅ **Decorator Pattern solves this by wrapping the object dynamically.**

---

## 🏗️ Project Structure
```
DecoratorDesignPattern
│
├── ICar.cs
├── BMWCar.cs
├── CarDecorator.cs
├── PetrolCarDecorator.cs
├── DieselCarDecorator.cs
└── Program.cs
```

---

## 🔑 Key Components
- **ICar** – Component interface
- **BMWCar** – Concrete component
- **CarDecorator** – Base decorator
- **PetrolCarDecorator / DieselCarDecorator** – Concrete decorators

---

## ▶️ Execution Flow
1. Create `BMWCar`
2. Wrap with decorator
3. Call `ManufactureCar()`
4. Engine added dynamically

---

## ✅ Advantages
- Open/Closed Principle
- Flexible and extensible
- Avoids inheritance explosion

---

## 🧑‍💻 Author
Decorator Design Pattern – C# Example
