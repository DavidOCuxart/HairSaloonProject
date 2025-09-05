using CommunityToolkit.Mvvm.ComponentModel; // ObservableObject, ObservableProperty
using CommunityToolkit.Mvvm.Input;          // RelayCommand
using CommunityToolkit.Mvvm.Messaging;      // IMessenger, Messenger
using CommunityToolkit.Mvvm.Messaging.Messages;
using TestProject.Messages;
using TestProject.Pages; // tipos de mensajes predefinidos opcionales


namespace TestProject.ViewModel;

public partial class MainViewModel : ObservableObject
{
    private readonly IMessenger _messenger;

    [ObservableProperty]
    private string name;

    [ObservableProperty]
    private string password;

    [ObservableProperty]
    private bool registerVisible = true;

    public event EventHandler<string> LoginFailed;

    public MainViewModel(IMessenger messenger)
    {
        _messenger = messenger;
    }

    [RelayCommand]
    public async Task LogInAsync()
    {
        if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(password))
        {
            _messenger.Send(new NotificationMessage("Datos de login vacíos"));
        }
        // Llamada a la API
        
        if(name == "David" && password == "12345")
        {
            //sdasdasdasdasda
            _messenger.Send(new NotificationMessage("Los datos se han introducido correctamente"));
            await Shell.Current.GoToAsync(nameof(MainMenuPage));
        }
    }

    [RelayCommand]
    void ToggleFields(string showRegister)
    {
        if(showRegister == "LogIn")
            RegisterVisible = false;
        else
            RegisterVisible = true;
    }


}
