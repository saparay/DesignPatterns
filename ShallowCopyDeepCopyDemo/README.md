# Shallow Copy vs Deep Copy in C#

## 📌 Overview

This example demonstrates the **difference between Shallow Copy and Deep Copy in C#** using a simple `Employee` and `Address` class. Understanding this concept is critical when working with **object cloning, Prototype Design Pattern, caching, and data isolation**.

---

## 🧠 Key Concepts

### 🔹 Shallow Copy

* Copies **primitive values** directly
* Copies **references** for reference-type objects
* Changes in referenced objects affect both original and clone

### 🔹 Deep Copy

* Copies primitive values
* Creates **new instances** for reference-type objects
* Changes in cloned objects **do not affect** the original

---

## 🏗️ Class Structure

### Employee

* Contains primitive properties (`Name`, `Department`)
* Contains a reference-type property (`Address`)
* Implements both shallow and deep copy methods

### Address

* Simple reference-type class
* Supports cloning using `MemberwiseClone()`

---

## 🔁 Copy Implementations

### Shallow Copy

```csharp
public Employee GetShallowCopy()
{
    return (Employee)this.MemberwiseClone();
}
```

* `EmpAddress` is **shared** between original and clone

### Deep Copy

```csharp
public Employee GetDeepCopy()
{
    Employee employee = (Employee)this.MemberwiseClone();
    employee.EmpAddress = EmpAddress.GetClone();
    return employee;
}
```

* `EmpAddress` is **independently cloned**

---

## ▶️ Program Flow

### Deep Copy Example

1. Create `emp1`
2. Clone using `GetDeepCopy()` → `emp2`
3. Modify `emp2.Name` and `emp2.EmpAddress.address`
4. `emp1` remains unchanged ✅

### Shallow Copy Example

1. Create `emp3`
2. Clone using `GetShallowCopy()` → `emp4`
3. Modify `emp4.Name` and `emp4.EmpAddress.address`
4. `emp3.EmpAddress` is also modified ❌

---

## 📤 Sample Output

```
Using Deep Copy
Employee 1: Name: Anurag, Address: BBSR
Employee 2: Name: Pranaya, Address: Mumbai

Using Shallow Copy
Employee 3: Name: Sambit, Address: Hyderabad
Employee 4: Name: Hina, Address: Hyderabad
```

---

## 🧪 Real-World Use Cases

* Prototype Design Pattern
* Caching systems
* Entity cloning in ORM (EF Core)
* Thread-safe object manipulation
* Configuration templates

---

## 🆚 Shallow vs Deep Copy Comparison

| Feature         | Shallow Copy | Deep Copy       |
| --------------- | ------------ | --------------- |
| Primitive types | Copied       | Copied          |
| Reference types | Shared       | New instance    |
| Data safety     | ❌ Risky      | ✅ Safe          |
| Performance     | Faster       | Slightly slower |

---

## 🎯 Interview Tips

> ❓ **When should you use Deep Copy?**

* When objects should be completely independent

> ❓ **How is this related to Prototype Pattern?**

* Prototype relies on cloning; choosing shallow vs deep copy affects behavior

> ❓ **What does `MemberwiseClone()` do?**

* Creates a shallow copy of the object

---

## ✅ Conclusion

* Use **Shallow Copy** when shared references are acceptable
* Use **Deep Copy** when isolation is required
* Always be cautious with reference-type properties

---

⭐ This example pairs perfectly with the **Prototype Design Pattern** and is a must-know concept for C# interviews.
