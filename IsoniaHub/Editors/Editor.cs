using IsoniaCore.DataGenerators;
using IsoniaCore.DataTypes;
using System.IO;
using System;

namespace IsoniaHub.Editors;

public class Editor : Observable
{
    private Version version;
    private DirectoryInfo editorPath;

    public string Name => $"Isonia {Version.ToString(3)}";
    public Version Version { get => version; set => OnPropertyChanged(ref version, value); }
    public DirectoryInfo EditorPath { get => editorPath; set => OnPropertyChanged(ref editorPath, value); }

    public Editor()
    {
    }

    public static Editor RandomEditor => new()
    {
        Version = new Version(
                      NumberDataGenerator.RandomInt(),
                      NumberDataGenerator.RandomInt(),
                      NumberDataGenerator.RandomInt(),
                      NumberDataGenerator.RandomInt()
                    ),
        EditorPath = new(TextDataGenerator.RandomWords(3, 6, Path.DirectorySeparatorChar)),
    };
}