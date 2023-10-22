using IsoniaCore.DataTypes;
using IsoniaHub.Editors;
using System.IO;
using System;

namespace IsoniaHub.Projects;

public class Project : Observable
{
    public string Name;
    public DirectoryInfo Path;

    public TimeSpan LastModified;

    public Editor Editor;

    public Project()
    {
    }
}