using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;

namespace IsoniaHub;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            // Create an instance of HubViewModel
            HubViewModel hubViewModel = new();

            // Create an instance of the view
            HubView hubView = new(hubViewModel);

            // Set the MainWindow of the appication
            desktop.MainWindow = hubView;
        }

        base.OnFrameworkInitializationCompleted();
    }
}