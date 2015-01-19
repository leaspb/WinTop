using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WinTop.Domain;

namespace WinTop.Transport.WebSocket
{
    public class WebSocketService : ITransportService
    {
        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        public void BroadcastServerInfo(ServerInfo serverInfo)
        {
            throw new NotImplementedException();
        }

        public void BroadcastHighloadMessage(string message)
        {
            throw new NotImplementedException();
        }

        public event EventHandler OnGetServerInfo;
        public event EventHandler<RefreshIntervalEventArgs> OnSetRefreshInterval;
    }
}
