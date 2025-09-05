using CommunityToolkit.Mvvm.Messaging;
using System.Threading.Tasks;
using TestProject.Messages;
using TestProject.ViewModel;

namespace TestProject;

public partial class MainPage : ContentPage
{
    bool visible = false;

    private List<Label> labels;
    private List<Entry> entries;

    public MainPage()
    {
        InitializeComponent();

        labels = new List<Label>
        {
            emailLabel,
            phoneLabel,
            postalLabel
        };
        entries = new List<Entry>
        {
            emailEntry,
            phoneEntry,
            postalEntry
        };
        
        foreach (Label label in labels)
        {
            label.VerticalOptions = LayoutOptions.Center;
        }

        var vm = new MainViewModel(WeakReferenceMessenger.Default);
        BindingContext = vm;

        // Suscribirse a los mensajes
        WeakReferenceMessenger.Default.Register<NotificationMessage>(this, (r, m) =>
        {
            DisplayAlert("Notificación", m.Text, "Aceptar");
        });

    }

    private void LogInShow(object? sender, EventArgs e)
    {
        visible = !visible;

        foreach (var label in labels)
            label.IsVisible = visible;

        foreach (var entry in entries)
            entry.IsVisible = visible;
    }
}
