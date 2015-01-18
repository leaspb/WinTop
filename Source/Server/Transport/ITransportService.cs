using System;

using WinTop.Domain;

namespace WinTop.Transport
{
    interface ITransportService
    {
        void Start();
        void Stop();

        void SendServerInfo(ServerInfo serverInfo);
        void SendHighloadMessage(string message);

        event EventHandler OnGetServerInfo;
        event EventHandler<RefreshIntervalEventArgs> OnSetRefreshInterval;
    }
}
