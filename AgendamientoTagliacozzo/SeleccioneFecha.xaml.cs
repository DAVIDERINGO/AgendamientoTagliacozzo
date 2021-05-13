using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AgendamientoTagliacozzo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SeleccioneFecha : ContentPage
    {
        public SeleccioneFecha(string usuario, string estudioenvia)
        {
            InitializeComponent();
            lblestudio.Text = estudioenvia;
            lblUser.Text = usuario;
        }

        private async void btnDisponibilidad_Clicked(object sender, EventArgs e)
        {
            var usarioenvia = lblUser.Text;
            var estudio = lblestudio.Text;
            var data = DatePicker.DateProperty.DefaultValue.ToString();
            var hora = TimePicker.TimeProperty.DefaultValue.ToString();
            
            await Navigation.PushAsync(new RegistroDatos(usarioenvia, estudio, data, hora));
        }
    }
}