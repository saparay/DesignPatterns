# Composite Design Pattern -- Real-Time Example in C

## 📌 Overview

This project demonstrates the **Composite Design Pattern** using a
real-world file system example in C#.

The Composite Pattern allows you to treat individual objects (files) and
groups of objects (directories) uniformly.

In this example: - **FileItem** → Leaf - **Directory** → Composite -
**FileSystemItem** → Component - **Program.cs** → Client

------------------------------------------------------------------------

## 🏗 Project Structure

    CompositeDesignPatternRealTimeExample/
    │
    ├── Program.cs
    ├── FileSystemItem.cs
    ├── FileItem.cs
    └── Directory.cs

------------------------------------------------------------------------

## 🎯 Design Pattern Participants

### 1️⃣ Component (FileSystemItem)

Defines common interface for files and directories.

``` csharp
public abstract class FileSystemItem
{
    public string Name { get; }
    public abstract decimal GetSizeinKB();
}
```

------------------------------------------------------------------------

### 2️⃣ Leaf (FileItem)

Represents individual files.

``` csharp
public class FileItem : FileSystemItem
{
    public long FileBytes { get; }

    public override decimal GetSizeinKB()
    {
        return decimal.Divide(this.FileBytes, 1024);
    }
}
```

------------------------------------------------------------------------

### 3️⃣ Composite (Directory)

Represents folders that contain files or other folders.

``` csharp
public class Directory : FileSystemItem
{
    private List<FileSystemItem> Childrens;

    public override decimal GetSizeinKB()
    {
        return this.Childrens.Sum(x => x.GetSizeinKB());
    }
}
```

------------------------------------------------------------------------

### 4️⃣ Client (Program.cs)

Builds and uses the file system hierarchy.

``` csharp
Directory RootDirectory = new Directory("Root");
RootDirectory.AddComponent(Folder1);
```

------------------------------------------------------------------------

## 🔄 How It Works

1.  Files are created as `FileItem` objects.
2.  Directories are created as `Directory` objects.
3.  Directories can contain:
    -   Files
    -   Other directories
4.  Calling `GetSizeinKB()` on any object:
    -   File → Returns file size
    -   Directory → Returns sum of all children

------------------------------------------------------------------------

## ▶️ Execution Flow

    RootDirectory
    │
    ├── Folder1
    │   ├── MyBook.txt
    │   ├── MyVideo.mp4
    │   └── SubFolder1
    │       ├── MyMusic.mp3
    │       └── MyResume.pdf
    │
    └── Folder2
        ├── MySoftware.exe
        └── MyDocument.doc

When `GetSizeinKB()` is called: - Folder → Calculates children size -
Root → Calculates everything

------------------------------------------------------------------------

## 📤 Sample Output

    Composite Objects:
    Total size of (RootDirectory): 85662 KB
    Total size of (Folder 1): 1003 KB
    Total size of (Folder 2): 85250 KB
    Total size of (SubFolder 1): 37 KB

    Leaf Objects:
    Total size of MyVideo File: 976 KB
    Total size of MyResume File: 17 KB
    Total size of MyBook File: 11 KB
    Total size of MyDocument File: 84960 KB

------------------------------------------------------------------------

## ✅ Advantages

✔ Simplifies hierarchical structures\
✔ Treats individual and composite objects equally\
✔ Follows Open/Closed Principle\
✔ Improves scalability

------------------------------------------------------------------------

## ⚠️ Important Note

In `Program.cs`, there is a small bug:

``` csharp
RootDirectory.AddComponent(Folder1);
RootDirectory.AddComponent(Folder1); // Duplicate
```

It should be:

``` csharp
RootDirectory.AddComponent(Folder1);
RootDirectory.AddComponent(Folder2);
```

------------------------------------------------------------------------

## 📚 When to Use Composite Pattern

Use this pattern when:

-   You need tree-like structures
-   You want uniform treatment of objects
-   You have hierarchical data

Examples: - File systems - Organization charts - UI components - Menu
systems

------------------------------------------------------------------------

## 🛠 How to Run

1.  Open in Visual Studio
2.  Create Console Application
3.  Add all class files
4.  Build & Run

Or using CLI:

``` bash
dotnet new console
dotnet run
```

