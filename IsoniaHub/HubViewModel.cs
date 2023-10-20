using IsoniaCore.ViewModels;
using System;
using System.Reflection;

namespace IsoniaHub;

public class HubViewModel : ViewModelBase
{
    private static readonly Version? version = Assembly.GetEntryAssembly()?.GetName().Version;
    private static readonly string? title = Assembly.GetExecutingAssembly()?.GetCustomAttribute<AssemblyTitleAttribute>()?.Title;

    public Version? Version => version;
    public new string? Title => title;

    public HubViewModel()
    {
    }
}