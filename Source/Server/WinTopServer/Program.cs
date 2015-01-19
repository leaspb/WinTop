using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StructureMap;

using WinTop.InfoAnalyzer;
using WinTop.InfoAnalyzer.Hardware;
using WinTop.InfoProvider;
using WinTop.InfoProvider.Wmi;
using WinTop.Transport;
using WinTop.Transport.WebSocket;

namespace WinTop.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            IContainer container = ConfigureDependencies();

            IAppEngine appEngine = container.GetInstance<IAppEngine>();
            appEngine.Run();

            Console.WriteLine("The server started successfully, press key 'q' to stop it!");

            while (Console.ReadKey().KeyChar != 'q')
            {
                continue;
            }

            appEngine.Stop();

            Console.WriteLine("The server was stopped!");
        }

        private static IContainer ConfigureDependencies()
        {
            return new Container(x =>
            {
                x.For<IAppEngine>().Use<AppEngine>();
                x.For<IInfoProvider>().Use<WmiInfoProvider>();
                x.For<IInfoAnalyzer>().Use<HardwareInfoAnalyzer>();
                x.For<ITransportService>().Use<WebSocketService>();
            });
        }
    }
}
