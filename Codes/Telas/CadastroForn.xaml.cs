using Microsoft.Maui.Controls;

namespace Codes
{
    public partial class CadastroForn : ContentPage
    {
        public CadastroForn()
        {
            InitializeComponent();

            // Adicione a lógica para os eventos dos botões aqui
            ButtonVoltar.Clicked += (sender, args) =>
            {
                // Navegue para a página anterior
                Navigation.PopAsync();
            };

            ButtonEntrar.Clicked += (sender, args) =>
            {
                // Valide os dados e salve o usuário
                // ...
            };
        }
    }
}