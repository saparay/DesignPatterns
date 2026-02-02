using System;
namespace BridgeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Except for the initialization phase, where an Abstraction object gets i.e. SonyRemoteControl or SamsungRemoteControl
            // linked with a specific Implementation object i.e. new SonyLedTv() or new SamsungLedTv(), 
            // the client code should only depend on the Abstraction class i.e. SonyRemoteControl or SamsungRemoteControl. 
            AbstractRemoteControl sonyRemoteControl = new SonyRemoteControl(new SonyLedTv());
            sonyRemoteControl.SwitchOn();
            sonyRemoteControl.SetChannel(101);
            sonyRemoteControl.SwitchOff();

            Console.WriteLine();

            AbstractRemoteControl samsungRemoteControl = new SamsungRemoteControl(new SamsungLedTv());
            samsungRemoteControl.SwitchOn();
            samsungRemoteControl.SetChannel(202);
            samsungRemoteControl.SwitchOff();

            Console.ReadKey();
        }
    }
}