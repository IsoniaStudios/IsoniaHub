using IsoniaCore.DataTypes;
using System.IO;
using System;

namespace IsoniaHub.Editors;

public class Editor : Observable
{
    private Version version;
    private DirectoryInfo path;

    public Version Version { get => version; set => OnPropertyChanged(ref version, value); }
    public DirectoryInfo Path { get => path; set => OnPropertyChanged(ref path, value); }

    public Editor()
    {
    }
}