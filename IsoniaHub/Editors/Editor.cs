using IsoniaCore.DataTypes;

namespace IsoniaHub.Editors;

public class Editor : Observable
{
    public Editor()
    {
    }

    public bool Locate()
    {
        return false;
        /*
        // open the uninstall registry key
        using (RegistryKey? uninstallRegistryKey = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Uninstall", true))
        {
            // nullability check
            if (uninstallRegistryKey is null)
            {
                // we do not have 
                return false;
            }

            // create a new subkey for your application
            using (RegistryKey subkey = uninstallRegistryKey.CreateSubKey(InstallerProperties.ApplicationName))
            {
                // set the display name
                subkey.SetValue("DisplayName", InstallerProperties.ApplicationName);
                // Set the icon path
                subkey.SetValue("DisplayIcon", $"{InstallerProperties.InstallDirectory}\\Pictures\\Volvo.ico");
                // Set the version
                subkey.SetValue("DisplayVersion", InstallerProperties.CurrentVersion);
                // Set the publisher
                subkey.SetValue("Publisher", "Combitech");
                // set the uninstall string
                subkey.SetValue("UninstallString", $"\"{InstallerProperties.InstallDirectory}\\{InstallerProperties.ApplicationName} Uninstaller.exe\"");
                // set the uninstall string
                subkey.SetValue("EstimatedSize", sizeInBytes / 1024.0, RegistryValueKind.DWord);
            }
        }
        */
    }
}