using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPatternRealTimeExamples.PaymentGatewayIntegration
{
    public class StripeGateway : IPaymentGateway
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing ${amount} payment through Stripe...");
            // Actual integration and logic for Stripe
        }
    }
}
