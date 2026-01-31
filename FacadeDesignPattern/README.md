## Facade Design Pattern – Order Processing Example
### 📌 Overview

This project demonstrates the Facade Design Pattern in C# using a simple Order Processing use case.

The Facade pattern provides a simplified interface to a complex subsystem. Instead of interacting with multiple subsystem classes directly, the client interacts with a single facade class.

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

### 🧩 Problem Statement

Placing an order involves multiple steps:

* Fetching product details
* Making payment
* Sending an invoice

If the client interacts with all subsystems directly:

* Code becomes tightly coupled ❌
* Client logic becomes complex ❌
* Maintenance becomes difficult ❌

----------------------------------------------------------------------------------------------------------------------------------------

### ✅ Solution – Facade Pattern

Introduce a Facade (Order) that:

* Coordinates calls to multiple subsystems

* Exposes a single method to the client

* Hides internal system complexity

### 🏗️ Project Structure

```
FacadeDesignPattern
│
├── Product.cs
├── Payment.cs
├── Invoice.cs
├── Order.cs        // Facade
└── Program.cs     // Client
```
-----------------------------------------------------

### 🧠 Key Components
### 1️⃣ Subsystems

Subsystems perform specific tasks and contain business logic.

Product

```
public void GetProductDetails()

```

Payment
```
public void MakePayment()

```

Invoice
```
public void Sendinvoice()

```
### 2️⃣ Facade – Order

```
public void PlaceOrder()

```

* Acts as a wrapper around subsystems

* Calls product, payment, and invoice in sequence

* Provides a clean and simple API

### 3️⃣ Client – Program
```
Order order = new Order();
order.PlaceOrder();

```

* Client interacts only with the Facade
* No dependency on subsystem classes

### ▶️ Execution Flow

1. Client calls PlaceOrder()

2. Product details are fetched

3. Payment is processed

4. Invoice is sent

5. Order placed successfully ✅

### 🧪 Sample Output

```
Place Order Started
Fetching the Product Details
Payment Done Successfully
Invoice Send Successfully
Order Placed Successfully

```

### 🎯 When to Use Facade Pattern

* To simplify complex systems

* To reduce tight coupling

* To improve readability and maintainability

* Common in:

	* Order processing systems

	* Payment gateways

	* API gateways

	* Service layers

### ⚠️ When NOT to Use
 
* When the system is already simple

* When abstraction adds unnecessary complexity

### 📘 Design Pattern Category

Structural Design Pattern

### 🧑‍💻 Interview Tip

Explain Facade as:

“A design pattern that provides a simple interface to a complex subsystem.”