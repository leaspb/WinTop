using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinTop.Domain
{
    public class ServerInfo
    {
        public ProcessInfo ProcessInfo { get; set; }
        public TaskInfo TaskInfo { get; set; }
        public CpuInfo CpuInfo { get; set; }
        public RamInfo RamInfo { get; set; }
        public SwapInfo SwapInfo { get; set; }
    }
}
