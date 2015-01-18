using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WinTop.InfoProvider;
using WinTop.Transport;

namespace WinTop.Server
{
    public class AppEngine : IAppEngine
    {
        private readonly IInfoProvider _infoProvider;
        private readonly ITransportService _transportService;

        public AppEngine(IInfoProvider infoProvider, ITransportService transportService)
        {
            _infoProvider = infoProvider;
            _transportService = transportService;
        }

        public void Run()
        {

        }
    }
}
