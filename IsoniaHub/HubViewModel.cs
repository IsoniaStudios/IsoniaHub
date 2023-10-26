using System.Collections.ObjectModel;
using System.Reflection;
using System.Linq;
using System;
using IsoniaCore.ViewModels;
using IsoniaCore.DataTypes;
using IsoniaHub.Projects;
using IsoniaHub.Editors;

namespace IsoniaHub;

public class HubViewModel : Observable
{
    private static readonly Version? version = Assembly.GetExecutingAssembly()?.GetName().Version;
    private static readonly string? title = Assembly.GetExecutingAssembly()?.GetCustomAttribute<AssemblyTitleAttribute>()?.Title;

    public Version? Version => version;
    public string? Title => title;

    private ViewModelBase selectedTab;
    public ViewModelBase SelectedTab { get => selectedTab; set => OnPropertyChanged(ref selectedTab, value); }
    public ObservableCollection<ViewModelBase> Tabs { get; }

    public HubViewModel()
    {
        Tabs = new ObservableCollection<ViewModelBase>()
        {
            new ProjectsViewModel(),
            new EditorsViewModel()
        };
        SelectedTab = Tabs.First();
    }
}