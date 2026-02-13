# Cache Proxy Design Pattern in C#

## Overview

This project demonstrates the Cache Proxy Design Pattern using C#.

A cache proxy stores previously fetched data and returns it from memory instead of repeatedly accessing the database. This improves performance and reduces unnecessary database calls.

---

## Design Pattern

Pattern Name: Proxy Pattern (Caching Proxy)  
Category: Structural Design Pattern

Purpose:
- Controls access to an object
- Adds caching behavior
- Improves performance

---

## Project Structure

### IProfilePictureService (Interface)

Defines a common interface.

```csharp
public interface IProfilePictureService
{
    byte[] GetProfilePicture(int userId);
}
```
------------------------------ 

## DatabaseProfilePictureService (Real Subject)

### Fetches profile pictures from database.

```csharp
public class CachedProfilePictureService : IProfilePictureService
{
    private readonly IProfilePictureService _service;
    private readonly Dictionary<int, byte[]> _cache =
        new Dictionary<int, byte[]>();

    public CachedProfilePictureService(IProfilePictureService service)
    {
        _service = service;
    }

    public byte[] GetProfilePicture(int userId)
    {
        if (_cache.ContainsKey(userId))
        {
            Console.WriteLine($"Returning cached profile picture for user {userId}.");
            return _cache[userId];
        }

        var picture = _service.GetProfilePicture(userId);
        _cache[userId] = picture;
        return picture;
    }
}

```

------------------

## Program (Client Code)

### Uses proxy service.

```csharp
public class Program
{
    public static void Main()
    {
        IProfilePictureService service =
            new CachedProfilePictureService(
                new DatabaseProfilePictureService());

        var pic1 = service.GetProfilePicture(1);
        var pic2 = service.GetProfilePicture(1);
        var pic3 = service.GetProfilePicture(2);

        Console.ReadKey();
    }
}
```

-------------------

## Execution Flow

* Client requests profile picture

* Proxy checks cache

* If exists → return cached data

* If not → fetch from database

* Store in cache

* Return to client

--------------------

## Sample Output

```css
Fetching profile picture for user 1 from database...
Returning cached profile picture for user 1.
Fetching profile picture for user 2 from database...

```
------

## Advantages

* Faster performance

* Reduced database load

* Better scalability

* Transparent to client

--------------------------
* 
## Disadvantages

* Extra memory usage

* Cache management needed

* Slightly more complex code


----------------------

## Real World Uses

* User profile images

* Product images

* API responses

* Config data

* Session storage