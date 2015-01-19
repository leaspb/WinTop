using System;

using WinTop.Domain;

namespace WinTop.Transport
{
    public interface ITransportService
    {
        void Start();
        void Stop();

        void BroadcastServerInfo(ServerInfo serverInfo);
        void BroadcastHighloadMessage(string message);

        event EventHandler OnGetServerInfo;
        event EventHandler<RefreshIntervalEventArgs> OnSetRefreshInterval;
    }
}
