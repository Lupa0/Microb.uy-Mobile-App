namespace MicrobApp.Views
{
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();

            var menuItems = new List<MenuItem>
            {
                new MenuItem { Text = "Notificaciones", IconImageSource = "notifications_icon.svg" },
                new MenuItem { Text = "Reglas", IconImageSource = "format_list_bulleted_icon.svg" },
                new MenuItem { Text = "Info", IconImageSource = "help_icon.svg" },
                new MenuItem { Text = "Cerrar sesi�n", IconImageSource = "logout_icon.svg" }
            };

            menuCollectionView.ItemsSource = menuItems;
        }

        private async void MenuCollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.FirstOrDefault() is MenuItem selectedItem)
            {
                // Maneja la redirecci�n o cualquier otra acci�n seg�n el �tem seleccionado
                switch (selectedItem.Text)
                {
                    case "Notificaciones":
                        Console.WriteLine("Ajustes Notificaciones");
                        // Redirige a la pantalla de notificaciones
                        await Shell.Current.GoToAsync("..");
                        break;
                    case "Reglas":
                        Console.WriteLine("Reglas Servidor");
                        // Redirige a la pantalla de reglas
                        await Shell.Current.GoToAsync("..");
                        break;
                    case "Info":
                        Console.WriteLine("Info de la app");
                        // Redirige a la pantalla de informaci�n
                        await Shell.Current.GoToAsync("..");
                        break;
                    case "Cerrar sesi�n":
                        SecureStorage.RemoveAll();
                        await Shell.Current.GoToAsync("../LoginPage");
                        break;
                }

                // Desmarca la selecci�n del �tem
                menuCollectionView.SelectedItem = null;
            }
        }
    }
}
