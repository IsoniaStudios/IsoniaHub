using Avalonia.Platform.Storage;
using Avalonia.Controls;
using Avalonia.Input;
using System.Collections.Generic;

namespace IsoniaHub.Projects;

public partial class ProjectsView : UserControl
{
    public ProjectsView()
    {
        // Handle drop event
        AddHandler(DragDrop.DropEvent, Drop);

        // Initialize
        InitializeComponent();
    }

    private void Drop(object? sender, DragEventArgs e)
    {
        if (DataContext is not ProjectsViewModel projectsViewModel)
            return;

        IEnumerable<IStorageItem>? files = e.Data.GetFiles();
        if (files is null)
            return;

        foreach (IStorageItem file in files)
        {
            projectsViewModel.AddFromPath(file.Path);
        }
    }
}