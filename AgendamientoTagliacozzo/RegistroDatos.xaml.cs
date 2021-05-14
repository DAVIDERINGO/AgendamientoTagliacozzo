using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using Xamarin.Essentials;

namespace AgendamientoTagliacozzo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistroDatos : ContentPage
    {
        private SQLiteAsyncConnection _conn;
        public RegistroDatos(string usarioenvia, string estudio, string data, string hora)
        {
            InitializeComponent();
            _conn = DependencyService.Get<ISQLiteDB>().GetConnection();
            txtUsuario.Text = usarioenvia;
            txtEstudio.Text = estudio;
            txtFecha.Text = data;
            txtHorario.Text = hora;

        }

        private  void btnAgendar_Clicked(object sender, EventArgs e)
        {
            var DatosRegistro = new T_Paciente { codigo = Convert.ToInt32( txtCodigo.Text), nombre = txtNombre.Text, apellido = txtApellido.Text, edad=Convert.ToInt32(txtEdad.Text), direccion = txtDireccion.Text, telefono = txtTelefono.Text, estudio=txtEstudio.Text, fecha=txtFecha.Text, horario=txtHorario.Text, usuario=txtUsuario.Text };
            _conn.InsertAsync(DatosRegistro);
            //LimpiarFormulario();
            DisplayAlert("Mensaje", "Cita agendada correctamente", "Ok");

            
        }
        void LimpiarFormulario()
        {
            txtApellido.Text = "";
            txtCodigo.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
            txtEdad.Text = "";
            txtEstudio.Text = "";
            txtFecha.Text = "";
            txtHorario.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtUsuario.Text = "";
        }
        private async  void btnRegresar_Clicked(object sender, EventArgs e)
        {
            var mensaje = new EmailMessage("Registro nuevo usuario", "<h1> Bienvenido </h1> <h1>Le saludamos de centro de diagnostico Advmedical, su cita para el estudio "+txtEstudio.Text+" queda agendado para la fecha: "+txtFecha+" a las: "+txtHorario.Text+", le solicitamos que se dirija al area de IMAGENOLOGIA 30 minutos antes de su cita. </h1>  <h1>NOMBRE: "+ txtNombre.Text + "  </h1> <h1>APELLIDO:   " + txtApellido.Text + "</h1> <h1>DIRECCION:   " + txtDireccion.Text + "</h1><h1>TELEFONO:  " + txtTelefono.Text + " </h1> <h1>EDAD:   " + txtEdad.Text + "</h1> <h1>Saludos  </h1> <h1>Advmedical  </h1><h1>Para mas informacion o soporte tecnico municarse al 0995254417   </h1>", "dtnvh@hotmail.com", txtCorreo.Text);
            DisplayAlert("Mensaje", "Cita enviada al correo correctamente", "Ok");
            mensaje.BodyFormat = EmailBodyFormat.Html;
            await Email.ComposeAsync(mensaje);

            //await Navigation.PushAsync(new Ingreso());
        }
    }
}