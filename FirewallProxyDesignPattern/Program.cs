namespace FirewallProxyDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDocument publicDocument = new DocumentProxy("This is a public document.", "Public", "Employee");
            Console.WriteLine(publicDocument.ReadContent()); // This will print the content
            IDocument confidentialDocument = new DocumentProxy("This is a confidential document.", "Confidential", "Employee");
            Console.WriteLine(confidentialDocument.ReadContent()); // This will print "Access Denied!"
            IDocument topSecretDocument = new DocumentProxy("This is a top-secret document.", "Top-Secret", "Executive");
            Console.WriteLine(topSecretDocument.ReadContent()); // This will print the content
            Console.ReadKey();
        }
    }
}
