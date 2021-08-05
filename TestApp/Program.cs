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
                //    do
                //    {
                //        plcInterface.WriteDB(S7WordLength.Int, 1, 0, 30);
                //        int intValue = S7.GetIntAt((plcInterface.ReadDB(16, 0)), 0);
                //        Console.WriteLine(intValue.ToString());

                //        Thread.Sleep(5000);
                //} while (true) ;

                //Server Test Code
                do
                {
                    TempUIController tempUIController = new TempUIController(new AutomationDashboard.Services.TempUIService());
                    Console.WriteLine(tempUIController.Get());
                    Console.WriteLine(plcInterface.ReadWord(2));
                    Thread.Sleep(3000);
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
