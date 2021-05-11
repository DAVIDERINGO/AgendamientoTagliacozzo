using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AgendamientoTagliacozzo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EnvioCorreo : ContentPage
    {
        public EnvioCorreo()
        {
            InitializeComponent();
        }



        private async void EnviarCorreo_Clicked(object sender, EventArgs e)
        {
            var mensaje = new EmailMessage("Registro nuevo usuario", "<h1> Bienvenido </h1> <span>Por favor envienos su </span> <span>CEDULA:  </span> <span>NOMBRE:  </span> <span>APELLIDO:  </span> <span>DIRECCION:  </span><span>TELEFONO:  </span> <span>EDAD:  </span>", "dtnvh@hotmail.com");
            mensaje.BodyFormat = EmailBodyFormat.Html;
            await Email.ComposeAsync(mensaje);
        }
    }
}