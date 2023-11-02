using IsoniaCore.DataGenerators;
using IsoniaCore.DataTypes;
using IsoniaHub.Editors;
using System.IO;
using System;
using System.Threading.Tasks;
using System.Diagnostics;

namespace IsoniaHub.Projects;

public class Project : Observable
{
    private bool favorite;
    private string name;
    private DirectoryInfo projectPath;
    private DateTime lastModified;
    private Editor editor;

    public bool Favorite { get => favorite; set => OnPropertyChanged(ref favorite, value); }
    public string Name { get => name; set => OnPropertyChanged(ref name, value); }
    public DirectoryInfo ProjectPath { get => projectPath; set => OnPropertyChanged(ref projectPath, value); }
    public DateTime LastModified { get => lastModified; set => OnPropertyChanged(ref lastModified, value); }
    public Editor Editor { get => editor; set => OnPropertyChanged(ref editor, value); }

    public Project()
    {
        
    }

    public async Task<Process> Launch()
    {
        return null;
    }

    public static Project RandomProject => new()
    {
        Name = TextDataGenerator.RandomWord,
        ProjectPath = new(TextDataGenerator.RandomWords(3, 6, Path.DirectorySeparatorChar)),
        LastModified = TimeDataGenerator.GenerateRandomDate(),
        Editor = Editor.RandomEditor,
    };
}