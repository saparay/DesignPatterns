using FactoryDesignPatternRealTimeExamples.CloudStorageSystem;
using FactoryDesignPatternRealTimeExamples.LoggingSystem;
using FactoryDesignPatternRealTimeExamples.PaymentGatewayIntegration;

namespace FactoryDesignPattern
{
    public class Program
    {
        public static void Main()
        {
            //Console.WriteLine("Select the payment gateway (PayPal, Stripe, CreditCard): ");
            //string gatewayName = Console.ReadLine();
            //try
            //{
            //    IPaymentGateway paymentGateway = PaymentGatewayFactory.CreatePaymentGateway(gatewayName);
            //    paymentGateway.ProcessPayment(100.00M);  // Example amount
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.ReadKey();


            //ILogger logger;
            //logger = LoggerFactory.CreateLogger("console");
            //logger.Log("This is a console log!");
            //logger = LoggerFactory.CreateLogger("file");
            //logger.Log("This message is written to a file.");
            //// The beauty of this approach is that the client code remains unchanged
            //// even if we introduce new logger types in the future.
            //Console.ReadKey();


            Console.WriteLine("Select your storage provider (AmazonS3, AzureBlob, GoogleCloud): ");
            string providerName = Console.ReadLine();
            try
            {
                IStorageProvider storageProvider = StorageProviderFactory.CreateStorageProvider(providerName);
                storageProvider.SaveFile("sample.txt", new byte[] { 0x01, 0x02 });   // Example of using the storage provider
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}