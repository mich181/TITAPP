using Microsoft.Maui.Controls;

namespace TITAPP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            // Navegar a la página principal (NewPage1)
            await Navigation.PushAsync(new NewPage1());
        }

        private async void OnCreateAccountButtonClicked(object sender, EventArgs e)
        {
            // Navegar de vuelta a esta misma página (para simular creación de cuenta)
            await Navigation.PopToRootAsync();
        }
    }
}
