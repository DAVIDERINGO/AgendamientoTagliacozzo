using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
namespace AgendamientoTagliacozzo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ingreso : ContentPage
    {
        public Ingreso()
        {
            InitializeComponent();
        }

        private async void btnValidar_Clicked(object sender, EventArgs e)
        {
            string usuario = txtDato1.Text;
            string clave = txtDato2.Text;
            if (usuario == "estudiante2021" && clave == "uisrael2021")
            {
                await Navigation.PushAsync(new PedidoMedico());
            }
            else
            {
                await Navigation.PushAsync(new EnvioCorreo());
            }
        }

        private async void btnUbicacion_Clicked(object sender, EventArgs e)
        {
            await Map.OpenAsync(-0.16314, -78.47891, new MapLaunchOptions
            {
                Name = txtNombreUbica.Text,
                NavigationMode = NavigationMode.None
            });
        }
    }
}