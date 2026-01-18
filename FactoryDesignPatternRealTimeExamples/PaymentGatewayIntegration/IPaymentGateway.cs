using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPatternRealTimeExamples.PaymentGatewayIntegration
{
    public interface IPaymentGateway
    {
        void ProcessPayment(decimal amount);
    }
}
