using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

using WinTop.InfoAnalyzer;
using WinTop.InfoProvider;
using WinTop.Transport;

namespace WinTop.Server
{
    public class AppEngine : IAppEngine
    {
        private readonly IInfoProvider _infoProvider;
        private readonly IInfoAnalyzer _infoAnalyzer;
        private readonly ITransportService _transportService;
        private readonly Timer _timer;

        public AppEngine(IInfoProvider infoProvider, IInfoAnalyzer infoAnalyzer, ITransportService transportService)
        {
            _infoProvider = infoProvider;
            _infoAnalyzer = infoAnalyzer;
            _transportService = transportService;

            _timer = new Timer
            {
                Interval = 1000,
                AutoReset = true
            };

            _timer.Elapsed += _timer_Elapsed;
        }

        public void Run()
        {
            _transportService.OnGetServerInfo += _transportService_OnGetServerInfo;
            _transportService.OnSetRefreshInterval += _transportService_OnSetRefreshInterval;

            _transportService.Start();
            _timer.Start();
        }

        public void Stop()
        {
            _transportService.Stop();
        }

        private void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            RefreshServerInfo();
        }

        private void _transportService_OnGetServerInfo(object sender, EventArgs e)
        {
            RefreshServerInfo();
        }

        private void _transportService_OnSetRefreshInterval(object sender, RefreshIntervalEventArgs e)
        {
            _timer.Interval = e.RefreshInterval;
        }

        private void RefreshServerInfo()
        {
            var serverInfo = _infoProvider.GetServerInfo();
            _transportService.BroadcastServerInfo(serverInfo);

            string highloadMessage;

            if (_infoAnalyzer.CheckForLoading(serverInfo, out highloadMessage) == LoadingStatus.Highload)
                _transportService.BroadcastHighloadMessage(highloadMessage);
        }
    }
}
