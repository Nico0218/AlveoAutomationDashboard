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
                //string ip = "192.168.1.5";
                //PLCInterface plcInterface = new PLCInterface();
                //plcInterface.Connect(ip);
                //Console.WriteLine("Is Connected: " + plcInterface.isConnected().ToString());
                //Console.WriteLine("Reading Int");
                //Console.WriteLine(plcInterface.ReadArea(18, 4, S7WordLength.Int));
                //Console.WriteLine("Reading word before change");
                //Console.WriteLine(plcInterface.ReadArea(2, 4, S7WordLength.Word));
                //ushort test = Convert.ToUInt16(new Random().Next(0, 100));
                //Console.WriteLine("Expected uint : "+ test.ToString());
                //plcInterface.WriteWord(2, test);
                //Console.WriteLine("Reading word after change");
                //Console.WriteLine(plcInterface.ReadArea(2, 4, S7WordLength.Word));
                //do {
                //    Console.WriteLine(plcInterface.ReadBuffer());
                //    Thread.Sleep(500);
                //} while (true);
                //plcInterface.Disconnect();
                //Console.WriteLine("Disconnected");

                //Server Test Code
                TempUIController tempUIController = new TempUIController(new AutomationDashboard.Services.TempUIService());
                Console.WriteLine(tempUIController.Get());

                Console.ReadKey();
            } catch (Exception ex) {
                throw ex;
            }
        }
    }
}
