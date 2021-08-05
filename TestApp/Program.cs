using AutomationDashboard.Controller;
using PLC_Client.Services;
using Sharp7;
using System;
using System.Threading;

namespace TestApp {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");

            try {
                string ip = "192.168.1.5";
                PLCInterface plcInterface = new PLCInterface();
                plcInterface.Connect(ip);
                Console.WriteLine("Is Connected: " + plcInterface.isConnected().ToString());
                //Server Implementation Test
                TempUIController tempUIController = new TempUIController(new AutomationDashboard.Services.TempUIService());
                Console.WriteLine(tempUIController.Get());
                plcInterface.Disconnect();
                Console.WriteLine("Disconnected");




                Console.ReadKey();
            } catch (Exception ex) {
                throw ex;
            }
        }
    }
}
