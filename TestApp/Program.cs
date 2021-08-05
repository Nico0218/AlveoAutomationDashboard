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
                //PLC implemation Test
                string ip = "192.168.1.5";
                PLCInterface plcInterface = new PLCInterface();
                plcInterface.Connect(ip);
                Console.WriteLine("Is Connected: " + plcInterface.isConnected().ToString());

                float test = S7.GetRealAt((plcInterface.ReadDB(41, 2)), 4);
                Console.WriteLine(test.ToString());
                plcInterface.realDbWrite(2, 4, (float)44.5);
                //TempUIController tempUIController = new TempUIController(new AutomationDashboard.Services.TempUIService());
                //Console.WriteLine(tempUIController.Get());




                plcInterface.Disconnect();
                Console.WriteLine("Disconnected");




                Console.ReadKey();
            } catch (Exception ex) {
                throw ex;
            }
        }
    }
}
