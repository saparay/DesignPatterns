# Builder Design Pattern – HTTP Request Builder Example

This project demonstrates the **Builder Design Pattern** in **C# (.NET Console Application)** using a **real-world HTTP request construction** scenario.

The example shows how to build a complex `HttpRequestMessage` step by step in a clean, readable, and maintainable way.

---

## 📌 What is the Builder Design Pattern?

The **Builder Design Pattern** is a creational design pattern that allows you to construct complex objects **incrementally**, using a step-by-step approach.

It separates:

* **How an object is built**
* **From what the final object represents**

This pattern is ideal when:

* An object has many optional parameters
* You want fluent, readable object creation
* Constructors would become too large or confusing

---

## 🎯 Real-World Use Case

In backend and API development, HTTP requests often require:

* HTTP method (GET, POST, PUT, DELETE)
* URI
* Headers (Authorization, Content-Type, etc.)
* Optional body content

Using constructors for all combinations leads to:

* Constructor overload explosion
* Poor readability
* Error-prone code

---

## ✅ Solution Using Builder Pattern

This example introduces:

* A **Builder interface** (`IHttpRequestBuilder`)
* A **Concrete Builder** (`HttpRequestBuilder`)
* A fluent API for method chaining
* A final `Build()` method to create the `HttpRequestMessage`

---

## 🧱 Project Structure

```
BuilderDesignPattern
│
├── IHttpRequestBuilder.cs     // Builder interface
├── HttpRequestBuilder.cs      // Concrete builder
├── Program.cs                 // Client code
└── README.md                  // Documentation
```

---

## 🔹 Step-by-Step Explanation

### 1️⃣ Builder Interface – `IHttpRequestBuilder`

Defines the steps required to build an HTTP request:

* `WithMethod(HttpMethod method)`
* `WithUri(Uri uri)`
* `WithContent(HttpContent content)`
* `WithHeader(string name, string value)`
* `Build()`

This ensures consistency across different builders.

---

### 2️⃣ Concrete Builder – `HttpRequestBuilder`

* Stores request configuration internally
* Implements all builder methods
* Returns `this` to support fluent chaining

The `Build()` method:

* Creates the `HttpRequestMessage`
* Applies headers, method, URI, and content

---

### 3️⃣ Client Code – `Program.cs`

The client:

* Uses the builder to configure the request
* Calls `Build()` to get the final request
* Sends the request using `HttpClient`

The client never deals with partial or invalid states directly.

---

## ▶️ Example Usage

```
var request = new HttpRequestBuilder()
    .WithMethod(HttpMethod.Post)
    .WithUri(new Uri("https://api.example.com/items"))
    .WithContent(new StringContent("{\"name\":\"sampleItem\"}", Encoding.UTF8, "application/json"))
    .WithHeader("Authorization", "Bearer my_token")
    .Build();
```

---

## ▶️ Sample Console Output

```
OK
```

(Actual output depends on API response)

---

## ⭐ Advantages of Builder Design Pattern

* Improves readability with fluent APIs
* Avoids large constructors
* Handles optional parameters cleanly
* Encourages immutability of final object
* Ideal for complex object creation

---

## ➕ Possible Enhancements

You can extend this builder by adding:

* `WithTimeout(TimeSpan timeout)`
* `WithQueryParameter(string key, string value)`
* `WithBearerToken(string token)`
* Validation inside `Build()` to ensure required fields are set

---

## 🆚 Builder vs Telescoping Constructors

| Builder Pattern          | Telescoping Constructors  |
| ------------------------ | ------------------------- |
| Readable and flexible    | Hard to read and maintain |
| Supports optional fields | Requires many overloads   |
| Fluent API               | Rigid API                 |

---

## 🧠 Key Takeaway

> The Builder Design Pattern is ideal for constructing complex objects like HTTP requests where multiple optional configurations are involved.

---

Happy Coding! 🚀
