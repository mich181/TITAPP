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
            await DisplayAlert("Contactos", "Abrir sección de Contactos.", "OK");
        }

        private async void OnMessagesClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Mensajes", "Abrir sección de Mensajes.", "OK");
        }

        private async void OnYouTubeClicked(object sender, EventArgs e)
        {
            await DisplayAlert("YouTube", "Abrir sección de YouTube.", "OK");
        }

        private async void OnRecipesClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Recetas", "Abrir sección de Recetas.", "OK");
        }
    }
}
