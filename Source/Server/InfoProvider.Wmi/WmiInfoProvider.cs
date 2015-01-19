using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

using WinTop.Domain;

namespace WinTop.InfoProvider.Wmi
{
    public class WmiInfoProvider : IInfoProvider
    {
        public WinTop.Domain.ServerInfo GetServerInfo()
        {
            return new ServerInfo();
        }
    }
}
