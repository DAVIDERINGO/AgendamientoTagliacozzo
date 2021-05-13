using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Media.Abstractions;
using Plugin.Media;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AgendamientoTagliacozzo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PedidoMedico : ContentPage
    {
        public PedidoMedico(string usuario)
        {
            InitializeComponent();
            lblUser.Text =  usuario;
        }

        private async void btnSeleccionarFoto_Clicked(object sender, EventArgs e)
        {
            if (CrossMedia.Current.IsTakePhotoSupported)
            {
                var imagen = await CrossMedia.Current.PickPhotoAsync();
                if (imagen != null)
                {
                    MiImagen.Source = ImageSource.FromStream(() =>
                    {
                        var stream = imagen.GetStream();
                        imagen.Dispose();
                        return stream;
                    });
                }
            }
        }

        private async void btnSeleccionarHorario_Clicked(object sender, EventArgs e)
        {
            var usuario = lblUser.Text;
            await Navigation.PushAsync(new SeleccioneEstudio(usuario));
        }
    }
}