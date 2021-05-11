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
    public partial class SeleccioneEstudio : ContentPage
    {
        public SeleccioneEstudio()
        {
            InitializeComponent();
        }

        private async  void btnSeleccionarHorario_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SeleccioneFecha());
        }
    }
}