using System;
namespace CompositeDesignPatternRealTimeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Client Code will work with all of the components (Both Leaf and Composite) via the base abstract class i.e. FileSystemItem.
            // FileSystemItem means the class that implements the FileSystemItem abstract class

            //Creating Leaf Objects i.e. Creating Files
            FileSystemItem MyBook = new FileItem("MyBook.txt", 12000);
            FileSystemItem MyVideo = new FileItem("MyVideo.mp4", 1000000);
            FileSystemItem MyMusic = new FileItem("MyMusic.mp3", 20000);
            FileSystemItem MyResume = new FileItem("MyResume.pdf", 18000);
            FileSystemItem MySoftware = new FileItem("MySoftware.exe", 250000);
            FileSystemItem MyDocument = new FileItem("MyDocument.doc", 87000000);

            //Create the Root Directory i.e. Composite Object 
            Directory RootDirectory = new Directory("RootDirectory");

            //Add 2 More Folders i.e. two more composite objects  
            Directory Folder1 = new Directory("Folder1");
            Directory Folder2 = new Directory("Folder2");

            //Add the above two folders under Root Directory
            RootDirectory.AddComponent(Folder1);
            RootDirectory.AddComponent(Folder1);

            //Add files to Folder 1   
            Folder1.AddComponent(MyBook);
            Folder1.AddComponent(MyVideo);

            //Create a Sub Folder1  
            Directory SubFolder1 = new Directory("Sub Folder1");

            //Add files under Sub Folder1  
            SubFolder1.AddComponent(MyMusic);
            SubFolder1.AddComponent(MyResume);

            //Add Sub Folder1 under Folder 1
            Folder1.AddComponent(SubFolder1);

            //Add files to folder 2  
            Folder2.AddComponent(MySoftware);
            Folder2.AddComponent(MyDocument);

            Console.WriteLine("Composite Objects:");
            Console.WriteLine($"Total size of (RootDirectory): {RootDirectory.GetSizeinKB()} KB");
            Console.WriteLine($"Total size of (Folder 1): {Folder1.GetSizeinKB()}KB");
            Console.WriteLine($"Total size of (Folder 2): {Folder2.GetSizeinKB()}KB");
            Console.WriteLine($"Total size of (SubFolder 1): {SubFolder1.GetSizeinKB()}KB");

            Console.WriteLine("\nLeaf Objects:");
            Console.WriteLine($"Total size of MyVideo File: {MyVideo.GetSizeinKB()}KB");
            Console.WriteLine($"Total size of MyResume File: {MyResume.GetSizeinKB()}KB");
            Console.WriteLine($"Total size of MyBook File: {MyBook.GetSizeinKB()}KB");
            Console.WriteLine($"Total size of MyDocument File: {MyDocument.GetSizeinKB()}KB");

            Console.Read();
        }
    }
}