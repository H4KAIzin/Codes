using Microsoft.Maui.Controls;

namespace Codes
{
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();

            // Adicione a lógica para os eventos dos botões aqui
            ButtonUsuario.Clicked += (sender, args) =>
            {
                // Navegue para a página de perfil do usuário
                Navigation.PushAsync(new PerfilPage());
            };

            ButtonMenu.Clicked += (sender, args) =>
            {
                // Abra o menu lateral ou modal
                // ...
            };
        }
    }
}