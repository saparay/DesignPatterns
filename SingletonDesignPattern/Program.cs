// See https://aka.ms/new-console-template for more information
using SingletonDesignPattern;

Console.WriteLine("Hello, World!");


Singleton fromTeacher = Singleton.GetInstance();

fromTeacher.PrintDetails("From Teacher");

Singleton fromStudent = Singleton.GetInstance();
fromStudent.PrintDetails("From Student");
