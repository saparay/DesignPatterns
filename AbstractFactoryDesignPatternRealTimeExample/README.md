# Abstract Factory Design Pattern – Media Processing Example

This project demonstrates the **Abstract Factory Design Pattern** in **C# (.NET Console Application)** using a real-world **media processing** scenario involving audio and video formats.

---

## 📌 What is the Abstract Factory Design Pattern?

The **Abstract Factory Design Pattern** is a creational design pattern that provides an interface for creating **families of related or dependent objects** without specifying their concrete classes.

It is especially useful when:

* Objects must be used together consistently
* The system should be independent of how objects are created
* You want to switch entire product families at runtime

---

## 🎯 Real-World Use Case

In multimedia applications, audio and video formats are often tightly related. For example:

* MP3 audio is commonly paired with MP4 video
* WAV audio is commonly paired with AVI video

The application should:

* Work with different format families
* Avoid hardcoding format-specific logic
* Ensure compatibility between audio and video processors

---

## ✅ Solution Using Abstract Factory Pattern

This project uses:

* **Abstract products** for audio and video processors
* **Concrete products** for specific media formats
* An **abstract factory** to define creation rules
* **Concrete factories** to create compatible processor families

The client code remains unchanged when switching media formats.

---

## 🧱 Project Structure

```
AbstractFactoryDesignPattern
│
├── IAudioProcessor.cs            // Abstract Product (Audio)
├── IVideoProcessor.cs            // Abstract Product (Video)
│
├── MP3Processor.cs               // Concrete Audio Product
├── MP4Processor.cs               // Concrete Video Product
├── WAVProcessor.cs               // Concrete Audio Product
├── AVIProcessor.cs               // Concrete Video Product
│
├── IMediaFactory.cs              // Abstract Factory
├── MP3MP4Factory.cs              // Concrete Factory (MP3 + MP4)
├── WAVAVIFactory.cs              // Concrete Factory (WAV + AVI)
│
├── MediaApplication.cs           // Client
├── Program.cs                    // Entry point
└── README.md                     // Documentation
```

---

## 🔹 Step-by-Step Explanation

### 1️⃣ Abstract Products

* `IAudioProcessor`
* `IVideoProcessor`

These interfaces define common operations for audio and video processing.

---

### 2️⃣ Concrete Products

Each media format provides its own implementation:

* **Audio**: `MP3Processor`, `WAVProcessor`
* **Video**: `MP4Processor`, `AVIProcessor`

Each class contains format-specific processing logic.

---

### 3️⃣ Abstract Factory – `IMediaFactory`

Defines methods to create **related objects**:

```
CreateAudioProcessor()
CreateVideoProcessor()
```

This ensures that compatible audio and video processors are created together.

---

### 4️⃣ Concrete Factories

* `MP3MP4Factory` → Creates MP3 audio + MP4 video processors
* `WAVAVIFactory` → Creates WAV audio + AVI video processors

Switching factories switches the entire media family.

---

### 5️⃣ Client Code – `MediaApplication`

The client:

* Receives a factory via constructor injection
* Uses only abstract interfaces
* Is completely decoupled from concrete implementations

---

## ▶️ Sample Console Output

```
Using MP3 & MP4 formats:
Processing MP3 audio file: song.mp3
Processing MP4 video file: video.mp4

Using WAV & AVI formats:
Processing WAV audio file: song.wav
Processing AVI video file: video.avi
```

---

## ⭐ Advantages of Abstract Factory Pattern

* Ensures compatibility between related objects
* Promotes loose coupling
* Supports Open/Closed Principle
* Makes switching product families easy
* Improves maintainability and scalability

---

## ➕ Adding a New Media Format Family

To add a new family (e.g., FLAC + MKV):

1. Create new audio and video processor classes
2. Implement `IMediaFactory` in a new factory
3. No changes required in `MediaApplication`

---

## 🆚 Factory vs Abstract Factory

| Factory Pattern        | Abstract Factory Pattern          |
| ---------------------- | --------------------------------- |
| Creates one product    | Creates families of products      |
| Uses conditional logic | Uses multiple factory methods     |
| Simpler                | More scalable for complex systems |

---

## 🧠 Key Takeaway

> Abstract Factory Pattern is ideal when your system needs to work with **multiple related objects** that must remain consistent across configurations.

---

Happy Coding! 🚀
