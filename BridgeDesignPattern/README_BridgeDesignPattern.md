# Bridge Design Pattern in C

## Overview

This project demonstrates the Bridge Design Pattern using a TV Remote
Control example in C#.

The Bridge Pattern decouples abstraction from implementation so that
both can vary independently.

## Structure

### Abstraction

-   AbstractRemoteControl

### Implementor

-   ILEDTV

### Concrete Implementations

-   SonyLedTv
-   SamsungLedTv

### Refined Abstractions

-   SonyRemoteControl
-   SamsungRemoteControl

## How It Works

-   Remote controls act as abstractions.
-   TV brands act as implementations.
-   Both can change independently.

## Example Usage

``` csharp
AbstractRemoteControl sonyRemoteControl = new SonyRemoteControl(new SonyLedTv());
sonyRemoteControl.SwitchOn();
sonyRemoteControl.SetChannel(101);
sonyRemoteControl.SwitchOff();
```

## Output

Turning ON : Sony TV\
Setting channel Number 101 on Sony TV\
Turning OFF : Sony TV

## Advantages

-   Separates interface from implementation
-   Improves scalability
-   Supports Open/Closed Principle

## When to Use

-   When abstraction and implementation should evolve independently
-   When you want to avoid tight coupling

## Author

Mani Chandra Saparay
