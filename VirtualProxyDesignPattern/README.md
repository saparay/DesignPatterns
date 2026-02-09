# Virtual Proxy Design Pattern -- Image Loading Example in C

## 📌 Overview

This project demonstrates the **Virtual Proxy Design Pattern** in C#
using an **Image Loading** example.

A Virtual Proxy controls access to a resource that is expensive to
create (like loading large images) and delays its creation until it is
actually needed.

In this example, images are loaded from disk **only when first
displayed**.

------------------------------------------------------------------------

## 🏗 Project Structure

    VirtualProxyDesignPattern/
    │
    ├── Program.cs
    ├── IImage.cs
    ├── RealImage.cs
    └── ProxyImage.cs

------------------------------------------------------------------------

## 🎯 Design Pattern Participants

### 1️⃣ Subject Interface (IImage)

Defines common operations for RealSubject and Proxy.

``` csharp
public interface IImage
{
    void DisplayImage();
}
```

------------------------------------------------------------------------

### 2️⃣ Real Subject (RealImage)

Represents the actual object that performs heavy operations.

``` csharp
public class RealImage : IImage
{
    private string Filename;

    public RealImage(string filename)
    {
        Filename = filename;
        LoadImageFromDisk();
    }
}
```

Loads the image when created.

------------------------------------------------------------------------

### 3️⃣ Proxy (ProxyImage)

Controls access and performs lazy loading.

``` csharp
public class ProxyImage : IImage
{
    private RealImage realImage = null;

    public void DisplayImage()
    {
        if (realImage == null)
        {
            realImage = new RealImage(Filename);
        }
        realImage.DisplayImage();
    }
}
```

Creates `RealImage` only when needed.

------------------------------------------------------------------------

### 4️⃣ Client (Program.cs)

Uses proxy instead of real image.

``` csharp
IImage image = new ProxyImage("Tiger Image");
image.DisplayImage();
```

------------------------------------------------------------------------

## 🔄 How It Works

1.  Client creates a ProxyImage.
2.  RealImage is NOT created immediately.
3.  When `DisplayImage()` is called:
    -   Proxy checks if RealImage exists.
    -   If not, creates it.
    -   Then displays the image.
4.  Subsequent calls reuse the loaded image.

------------------------------------------------------------------------

## ▶️ Execution Flow

    Client → ProxyImage → (Check Cache)
                        ↓
                   Create RealImage
                        ↓
                  Load From Disk
                        ↓
                     Display

------------------------------------------------------------------------

## 📤 Sample Output

    Image1 calling DisplayImage first time :
    Loading Image : Tiger Image
    Displaying Image : Tiger Image

    Image1 calling DisplayImage second time :
    Displaying Image : Tiger Image

    Image1 calling DisplayImage third time :
    Displaying Image : Tiger Image

Image is loaded only once.

------------------------------------------------------------------------

## ✅ Advantages

✔ Improves performance\
✔ Saves memory\
✔ Implements lazy loading\
✔ Reduces startup time\
✔ Controls resource usage

------------------------------------------------------------------------

## ⚠️ Important Notes

### 1. Lazy Initialization

RealImage is created only when required.

### 2. Thread Safety

For multithreaded apps, consider synchronization.

### 3. Resource Cleanup

In real projects, implement disposal for large resources.

------------------------------------------------------------------------

## 📚 Types of Proxy

This example demonstrates **Virtual Proxy**.

Other types include:

-   Protection Proxy
-   Remote Proxy
-   Caching Proxy
-   Logging Proxy

------------------------------------------------------------------------

## 📚 When to Use Virtual Proxy

Use this pattern when:

-   Objects are expensive to create
-   Resources should be loaded on demand
-   Startup performance matters

Examples: - Image viewers - Video streaming - Large file loaders - Cloud
resources

------------------------------------------------------------------------

## 🛠 How to Run

### Using Visual Studio

1.  Create Console App
2.  Add all class files
3.  Run project

### Using CLI

``` bash
dotnet new console
dotnet run
```

------------------------------------------------------------------------

## 📈 Performance Comparison

Without Proxy:

    All images loaded at startup
    High memory usage
    Slow startup

With Virtual Proxy:

    Images loaded on demand
    Low memory usage
    Fast startup

