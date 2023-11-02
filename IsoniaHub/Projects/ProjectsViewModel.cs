using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using IsoniaCore.Resources.Icons;
using IsoniaCore.ViewModels;
using IsoniaCore.DataTypes;

namespace IsoniaHub.Projects;

public class ProjectsViewModel : ViewModelBase
{
    // Unsorted list of projects
    private readonly List<Project> projects = new();

    public ObservableCollection<Project> Projects { get; } = new();

    public RelayCommand NewCommand { get; }
    private void New(object? _)
    {
        Projects.Add(Project.RandomProject);
    }

    public RelayCommand OpenCommand { get; }
    private void Open(object? _)
    {
        // open somthing idk
        AddFromPath(null);
    }

    internal void AddFromPath(Uri path)
    {
    }

    public ProjectsViewModel()
    {
        Title = "Projects";
        Icon = IconStore.ProjectIcon;

        OpenCommand = new RelayCommand(Open);
        NewCommand = new RelayCommand(New);

        // Dispatch a search for already added projects
        Task.Run(SearchForProjects);
    }

    private void SearchForProjects()
    {
        Projects.Add(Project.RandomProject);
    }
}