using System.Collections.ObjectModel;
using IsoniaCore.Resources.Icons;
using IsoniaCore.ViewModels;

namespace IsoniaHub.Projects;

public class ProjectsViewModel : ViewModelBase
{
    public ObservableCollection<Project> Projects { get; } = new();

    public ProjectsViewModel()
    {
        Title = "Projects";
        Icon = IconStore.ProjectIcon;
    }
}