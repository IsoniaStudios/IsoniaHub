using IsoniaCore.ViewModels;
using System.Reflection;

namespace IsoniaHub;

public class HubViewModel : ViewModelBase
{
    private static string version = Assembly.GetEntryAssembly()?.GetName().Version.ToString();
    public string Version => version;

    public bool Visible => true;

    public HubViewModel()
    {
        Title = "Isonia Hub";

    }
}