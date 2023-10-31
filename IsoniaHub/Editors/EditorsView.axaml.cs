using Avalonia.Platform.Storage;
using Avalonia.Controls;
using Avalonia.Input;
using System.Collections.Generic;

namespace IsoniaHub.Editors;

public partial class EditorsView : UserControl
{
    public EditorsView()
    {
        // Handle drop event
        AddHandler(DragDrop.DropEvent, Drop);

        // Initialize
        InitializeComponent();
    }

    private void Drop(object? sender, DragEventArgs e)
    {
        if (DataContext is not EditorsViewModel editorsViewModel)
            return;

        IEnumerable<IStorageItem>? files = e.Data.GetFiles();
        if (files is null)
            return;

        foreach (IStorageItem file in files)
        {
            editorsViewModel.AddFromPath(file.Path);
        }
    }
}