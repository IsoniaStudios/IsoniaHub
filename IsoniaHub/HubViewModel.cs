using IsoniaCore.DataTypes;
using System.Reflection;
using System;

namespace IsoniaHub;

public class HubViewModel : Observable
{
    private static readonly Version? version = Assembly.GetEntryAssembly()?.GetName().Version;
    private static readonly string? title = Assembly.GetEntryAssembly()?.GetCustomAttribute<AssemblyTitleAttribute>()?.Title;

    public Version? Version => version;
    public string? Title => title;

    public HubViewModel()
    {
    }
}