using IsoniaCore.DataGenerators;
using IsoniaCore.DataTypes;
using IsoniaHub.Editors;
using System.IO;
using System;

namespace IsoniaHub.Projects;

public class Project : Observable
{
    private bool favorite;
    private string name;
    private DirectoryInfo path;
    private DateTime lastModified;
    private Editor editor;

    public bool Favorite { get => favorite; set => OnPropertyChanged(ref favorite, value); }
    public string Name { get => name; set => OnPropertyChanged(ref name, value); }
    public DirectoryInfo Path { get => path; set => OnPropertyChanged(ref path, value); }
    public DateTime LastModified { get => lastModified; set => OnPropertyChanged(ref lastModified, value); }
    public Editor Editor { get => editor; set => OnPropertyChanged(ref editor, value); }

    public Project()
    {
        
    }

#if DEBUG
    public static Project RandomProject => new()
    {
        Name = string.RandomWord,
        Path = new(string.RandomPath),
        LastModified = DateTime.RandomTime,
    };
#endif
}