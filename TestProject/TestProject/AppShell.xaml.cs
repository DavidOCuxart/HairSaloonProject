using TestProject.Pages;

namespace TestProject
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(MainMenuPage), typeof(MainMenuPage)); 
        }
    }
}
