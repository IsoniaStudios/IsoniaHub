using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Threading.Tasks;
using IsoniaCore.Resources.Icons;
using IsoniaCore.ViewModels;
using IsoniaCore.DataTypes;
using System;

namespace IsoniaHub.Editors;

public class EditorsViewModel : ViewModelBase
{
    // Unsorted list of editors
    private readonly List<Editor> editors = new();

    public ObservableCollection<Editor> Editors  { get; } = new();

    public RelayCommand LocateCommand { get; }
    private void Locate(object? _)
    {
        // open somthing idk
        AddFromPath(null);
    }

    internal void AddFromPath(Uri path)
    {
    }

    public EditorsViewModel()
    {
        Title = "Editors";
        Icon = IconStore.InstallIcon;

        LocateCommand = new RelayCommand(Locate);

        // Dispatch a search for installed editors
        Task.Run(SearchForEditors);
    }

    private void SearchForEditors()
    {

    }
}