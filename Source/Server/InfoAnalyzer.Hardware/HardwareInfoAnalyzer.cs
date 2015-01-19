using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WinTop.Domain;

namespace WinTop.InfoAnalyzer.Hardware
{
    public class HardwareInfoAnalyzer : IInfoAnalyzer
    {
        public LoadingStatus CheckForLoading(ServerInfo serverInfo, out string message)
        {
            message = string.Empty;

            return LoadingStatus.OK;
        }
    }
}
