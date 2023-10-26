using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Win32;
using IsoniaCore.Resources.Icons;
using IsoniaCore.ViewModels;

namespace IsoniaHub.Editors;

public class EditorsViewModel : ViewModelBase
{
    private readonly List<Editor> editors = new();

    public ObservableCollection<Editor> Editors  { get; } = new();


    public EditorsViewModel()
    {
        Title = "Editors";
        Icon = IconStore.InstallIcon;
        editors.AddRange(SearchForEditors());
    }

    private IEnumerable<Editor> SearchForEditors()
    {
        // open the uninstall registry key
        using (RegistryKey? uninstallRegistryKey = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Uninstall", false))
        {
            // nullability check
            if (uninstallRegistryKey is null)
            {
                // we do not have 
                yield break;
            }

            
        }
    }
}