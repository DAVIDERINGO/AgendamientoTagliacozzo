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
            var mensaje = new EmailMessage("Registro nuevo usuario", "<h1> Bienvenido </h1> <h1>Le saludamos de centro de diagnostico Advmedical le solicitamos nos envie la siguiente informacion para generar su usuario y clave para que pueda ingresar y agendar su estudio en el  sistema su usuario y clave sera enviado por este medio en un lapso de 24 horas</h1> <h1>CEDULA:  </h1> <h1>NOMBRE:  </h1> <h1>APELLIDO:  </h1> <h1>DIRECCION:  </h1><h1>TELEFONO:  </h1> <h1>EDAD:  </h1> <h1>Saludos  </h1> <h1>Advmedical  </h1><h1>Para mas informacion o soporte tecnico municarse al 0995254417   </h1>", "dtnvh@hotmail.com");
            mensaje.BodyFormat = EmailBodyFormat.Html;
            await Email.ComposeAsync(mensaje);
        }
    }
}