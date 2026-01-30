# Adapter Design Pattern – Employee Payroll Example

## 📌 Overview
This project demonstrates the **Adapter Design Pattern** in C# using a real-world **HR Payroll** scenario.

The Adapter pattern allows two incompatible interfaces to work together.  
Here, an **HR system** provides employee data as a 2D string array, while a **third‑party billing system** expects a list of `Employee` objects.  
The **Adapter** bridges this gap without modifying existing code.

---

## 🧩 Problem Statement
- HR system outputs employee data as `string[,]`
- Third-party billing system processes salaries using `List<Employee>`
- Interfaces are incompatible ❌

### ✅ Solution
Introduce an **Adapter** that:
- Accepts the HR system format
- Converts it into the billing system format
- Delegates processing to the third-party system

---

## 🏗️ Project Structure
```
AdapterDesignPattern
│
├── Employee.cs
├── ThirdPartyBillingSystem.cs
├── ITarget.cs
├── EmployeeAdapter.cs
└── Program.cs
```

---

## 🧠 Key Components

### 1️⃣ Adaptee – ThirdPartyBillingSystem
```csharp
public void ProcessSalary(List<Employee> listEmployee)
```
- Existing system
- Cannot be changed
- Processes salary from a list of employees

---

### 2️⃣ Target Interface – ITarget
```csharp
void ProcessCompanySalary(string[,] employeesArray);
```
- Expected by the client (HR system)

---

### 3️⃣ Adapter – EmployeeAdapter
- Implements `ITarget`
- Internally uses `ThirdPartyBillingSystem`
- Converts `string[,]` ➝ `List<Employee>`

---

### 4️⃣ Client – Program
- Uses only the `ITarget` interface
- Completely unaware of the third-party system

---

## ▶️ Execution Flow
1. HR system sends employee data as `string[,]`
2. Adapter converts array to `List<Employee>`
3. Adapter calls `ThirdPartyBillingSystem`
4. Salaries are processed successfully ✅

---

## 🧪 Sample Output
```
HR system passes employee string array to Adapter

Adapter converted Array of Employee to List of Employee
Then delegate to the ThirdPartyBillingSystem for processing the employee salary

Rs.10000 Salary Credited to John Account
Rs.20000 Salary Credited to Smith Account
Rs.30000 Salary Credited to Dev Account
Rs.40000 Salary Credited to Pam Account
Rs.50000 Salary Credited to Sara Account
```

---

## 🎯 When to Use Adapter Pattern
- Integrating **legacy systems**
- Working with **third-party libraries**
- When interfaces are incompatible but functionality is required

---

## ⚠️ When NOT to Use
- When you can modify the source interface directly
- When conversion logic becomes overly complex

---

## 📘 Design Pattern Category
**Structural Design Pattern**

---

## 🧑‍💻 Author Notes
This example is **interview-friendly**, **real-world**, and commonly asked in:
- C# / .NET interviews
- System design discussions
- Design pattern rounds

---

Happy Coding 🚀
