using Microsoft.Maui.Controls;

namespace TITAPP
{
    public partial class NewPage1 : ContentPage
    {
        public NewPage1()
        {
            InitializeComponent();
        }

        

        private async void OnContactsClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Contactos", "Abrir secci�n de Contactos.", "OK");
        }

        private async void OnMessagesClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Mensajes", "Abrir secci�n de Mensajes.", "OK");
        }

        private async void OnYouTubeClicked(object sender, EventArgs e)
        {
            await DisplayAlert("YouTube", "Abrir secci�n de YouTube.", "OK");
        }

        private async void OnRecipesClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Recetas", "Abrir secci�n de Recetas.", "OK");
        }
    }
}
