using Avalonia.Controls;

namespace IsoniaHub;

public partial class HubView : Window
{
    public HubView(HubViewModel hubViewModel) : this()
    {
        // Set the datacontext
        DataContext = hubViewModel;
    }

    public HubView()
    {
        // Initialize
        InitializeComponent();
    }
}