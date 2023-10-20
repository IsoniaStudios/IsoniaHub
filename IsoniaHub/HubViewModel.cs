using IsoniaCore.ViewModels;
using System;
using System.Reflection;

namespace IsoniaHub;

public class HubViewModel : ViewModelBase
{
    public Version? Version => Assembly.GetEntryAssembly()?.GetName().Version;
    public new string? Title => Assembly.GetExecutingAssembly()?.GetCustomAttribute<AssemblyTitleAttribute>()?.Title;

    public HubViewModel()
    {
    }
}