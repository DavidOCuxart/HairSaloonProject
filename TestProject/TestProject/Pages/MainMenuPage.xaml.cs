
using TestProject.ViewModel;

namespace TestProject.Pages;

public partial class MainMenuPage : ContentPage
{
	public MainMenuPage(MainMenuViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}