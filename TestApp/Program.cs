using AutomationDashboard.Controller;
using PLC_Client.Services;
using Sharp7;
using System;
using System.Threading;

namespace TestApp {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Simulating Client Dashboard i'm assuming.");
            try {
                PLCInterface plcInterface = new PLCInterface();
                plcInterface.Connect();
                Console.WriteLine("Is Connected: " + plcInterface.isConnected().ToString());
                
                do
                {
                    TempUIController tempUIController = new TempUIController(new AutomationDashboard.Services.TempUIService());
                    Console.WriteLine(tempUIController.GetInt(24));
                    Thread.Sleep(1000);
                } while (true);

                plcInterface.Disconnect();
                Console.WriteLine("Disconnected");


                Console.ReadKey();
            } catch (Exception ex) {
                throw ex;
            }
        }
    }
}
