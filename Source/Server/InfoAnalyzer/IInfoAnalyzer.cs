using WinTop.Domain;

namespace WinTop.InfoAnalyzer
{
    public enum LoadingStatus
    {
        Unknown,
        OK,
        Highload
    }
    
    public interface IInfoAnalyzer
    {
        LoadingStatus CheckForLoading(ServerInfo serverInfo, out string message); 
    }
}
