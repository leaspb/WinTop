using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StructureMap;

using WinTop.InfoProvider;
using WinTop.Transport;

namespace WinTop.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            IContainer container = ConfigureDependencies();

            IAppEngine appEngine = container.GetInstance<IAppEngine>();
            appEngine.Run();
        }

        private static IContainer ConfigureDependencies()
        {
            return new Container(x =>
            {
                x.For<IAppEngine>().Use<AppEngine>();
                x.For<IInfoProvider>().Use<IInfoProvider>();
                x.For<ITransportService>().Use<ITransportService>();
            });
        }
    }
}
