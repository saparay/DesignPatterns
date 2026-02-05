# Flyweight Design Pattern -- Text Editor Example in C

## 📌 Overview

This project demonstrates the **Flyweight Design Pattern** using a
**Text Editor** example in C#.

Instead of creating a new style object for every character, the
application **reuses shared style objects** to save memory.

This is especially useful in applications like: - Text editors - Word
processors - IDEs - Document viewers

------------------------------------------------------------------------

## 🏗 Project Structure

    FlyweightDesignPatternRealTimeExample/
    │
    ├── CharacterStyle.cs
    ├── StyleFactory.cs
    ├── Character.cs
    ├── TextEditor.cs
    └── Program.cs

------------------------------------------------------------------------

## 🎯 Design Pattern Participants

### 1️⃣ Flyweight (CharacterStyle)

Stores intrinsic (shared) data.

``` csharp
public class CharacterStyle
{
    public string Font { get; }
    public int Size { get; }
    public bool IsBold { get; }
    public bool IsItalic { get; }
}
```

**Intrinsic State (Shared):** - Font - Size - IsBold - IsItalic

------------------------------------------------------------------------

### 2️⃣ Flyweight Factory (StyleFactory)

Creates and manages style objects.

``` csharp
public class StyleFactory
{
    private Dictionary<string, CharacterStyle> _styles;
}
```

Ensures only one instance exists per style.

------------------------------------------------------------------------

### 3️⃣ Context / Concrete Flyweight (Character)

Contains extrinsic (external) data.

``` csharp
public class Character
{
    public char Symbol { get; }
    public int Position { get; }
}
```

**Extrinsic State:** - Symbol - Position

------------------------------------------------------------------------

### 4️⃣ Client (TextEditor)

Uses factory and manages characters.

``` csharp
public class TextEditor
{
    private List<Character> _document;
}
```

------------------------------------------------------------------------

## 🔄 How It Works

1.  User inserts a character.
2.  TextEditor requests style from StyleFactory.
3.  Factory checks cache.
4.  If style exists → returns it.
5.  If not → creates new style.
6.  Character uses shared style.

This avoids duplicate style objects.

------------------------------------------------------------------------

## ▶️ Execution Flow

    Insert Character
          ↓
    Request Style → StyleFactory Cache
          ↓
    Create/Reuse Style
          ↓
    Create Character
          ↓
    Display

------------------------------------------------------------------------

## 📤 Sample Usage

``` csharp
var editor = new TextEditor();

editor.InsertCharacter('A', 0, "Arial", 12, true, false);
editor.InsertCharacter('B', 1, "Arial", 12, true, false);
editor.InsertCharacter('C', 2, "Times New Roman", 14, false, true);

editor.DisplayDocument();
```

------------------------------------------------------------------------

## 📊 Sample Output

    A Font: Arial, Size: 12, Bold: True, Italic: False
    -----
    B Font: Arial, Size: 12, Bold: True, Italic: False
    -----
    C Font: Times New Roman, Size: 14, Bold: False, Italic: True
    -----

Only **two style objects** are created and reused.

------------------------------------------------------------------------

## ✅ Advantages

✔ Reduces memory consumption\
✔ Improves performance\
✔ Centralized style management\
✔ Suitable for large documents

------------------------------------------------------------------------

## ⚠️ Important Notes

### 1. Flyweight Key Design

The key is generated as:

``` csharp
var key = $"{font}_{size}_{isBold}_{isItalic}";
```

Ensure keys are unique and consistent.

### 2. Thread Safety

For multi-threaded apps, use:

``` csharp
ConcurrentDictionary
```

------------------------------------------------------------------------

## 📚 When to Use This Pattern

Use Flyweight when:

-   You create many similar objects
-   Objects share most of their data
-   Memory is critical

Examples: - Text formatting - Map tiles - Game particles - UI components

------------------------------------------------------------------------

## 🛠 How to Run

### Using Visual Studio

1.  Create Console App
2.  Add all class files
3.  Run

### Using CLI

``` bash
dotnet new console
dotnet run
```

------------------------------------------------------------------------

## 📈 Memory Optimization Example

Without Flyweight:

    1000 characters = 1000 style objects

With Flyweight:

    1000 characters = few shared styles


